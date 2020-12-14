using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using winform_crud.Controllers.Order;
using winform_crud.Controllers.Table;
using winform_crud.DTO.Table;
using winform_crud.Models;
using System.Linq;

namespace winform_crud.Views.Order
{
    public partial class AddOrderView : BaseView
    {
        private readonly AddOrderController _addOrderController;
        private readonly ListAllTablesController _listAllTablesController;

        private readonly List<TableDTO> _viewTables;

        public AddOrderView()
        {
            InitializeComponent();

            _addOrderController = new AddOrderController();
            _listAllTablesController = new ListAllTablesController();

            _viewTables = new List<TableDTO>();
        }

        private void AddOrderView_Load(object sender, EventArgs e)
        {
            LoadViewTables();
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _addOrderController.Execute(default);
        }

        private void TableButton_Click(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;

            DialogResult dialogResult = MessageBox.Show(
                $"Confirma a abertura da mesa [ {currentButton.Text} ]?",
                "Abrir comanda", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                AddOrder(Convert.ToInt32(currentButton.Text));
                UpdateTableButtonStyles(currentButton, false);
            }
        }

        private void LoadViewTables()
        {
            var tables = _listAllTablesController.Execute();
            if (tables is null) return;

            foreach (TableDTO table in tables)
            {
                Button button = CreateTableButton(table.Number.ToString(), !table.IsBusy);
                TablesContainer.Controls.Add(button);
            }

            _viewTables.AddRange(tables);
        }

        private Button CreateTableButton(string buttonText, bool isEnabled)
        {
            Button button = new Button()
            {
                Text = buttonText,
                Location = new Point(10, 10),
                Size = new Size(48, 48),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };

            UpdateTableButtonStyles(button, isEnabled);

            button.FlatAppearance.BorderSize = 0;
            button.Click += new EventHandler(TableButton_Click);
            return button;
        }

        private void UpdateTableButtonStyles(Button button, bool isEnabled)
        {
            button.Enabled = isEnabled;
            button.BackColor = isEnabled ? Color.Green : Color.LightGray;
        }

        private void AddOrder(int tableNumber)
        {
            TableDTO selectedTable = _viewTables.FirstOrDefault(x => x.Number.Equals(tableNumber));
            OrderModel orderModel = new OrderModel(selectedTable.Id);

            _addOrderController.Execute(orderModel);            
        }        
    }
}
