using System;
using System.Windows.Forms;
using winform_crud.Controllers.Order;
using winform_crud.Views.OrderItem;

namespace winform_crud.Views.Order
{
    public partial class OrderView : BaseView
    {
        private readonly ListOrderController _listAllOrdersController;
        private readonly CloseOrderController _closeOrderController;

        public OrderView()
        {
            InitializeComponent();

            _listAllOrdersController = new ListOrderController();
            _closeOrderController = new CloseOrderController();
        }

        private void OrderView_Load(object sender, EventArgs e)
        {
            UpdateOrdersGridView();
        }

        private void OrdersGridView_DoubleClick(object sender, EventArgs e)
        {
            Guid? selectedOrderId = GetGridViewCurrentRowId();
            if (!selectedOrderId.HasValue)
            {
                return;
            }

            OrderItemDetailsView orderItemView = new OrderItemDetailsView(selectedOrderId.Value);
            DialogResult dialogResult = orderItemView.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
            }
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            AddOrderView addOrderView = new AddOrderView();
            DialogResult dialogResult = addOrderView.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                UpdateOrdersGridView();
            }
        }

        private void CloseOrderButton_Click(object sender, EventArgs e)
        {
            int? tableNumber = GetGridViewCurrentRowTableNumber();    
            if (!tableNumber.HasValue)
            {
                MessageBox.Show("Selecione uma comanda válida", "Comandas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show(
               $"Confirma o fechamento da mesa [ {tableNumber} ]?",
               "Fechar comanda",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Guid? selectedOrderId = GetGridViewCurrentRowId();
                if (!selectedOrderId.HasValue)
                {
                    MessageBox.Show("Selecione uma comanda válida", "Comandas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _closeOrderController.Execute(selectedOrderId.Value);
                UpdateOrdersGridView();
            }
        }

        private void RefreshGridViewButton_Click(object sender, EventArgs e)
        {
            UpdateOrdersGridView();
        }

        private Guid? GetGridViewCurrentRowId()
        {
            object cellIdValue = GetSelectedRowCellValue(0);

            if (cellIdValue is null) return null;
            return Guid.Parse(cellIdValue.ToString());
        }

        private int? GetGridViewCurrentRowTableNumber()
        {
            object cellTableNumberValue = GetSelectedRowCellValue(2);

            if (cellTableNumberValue is null) return null;
            return Convert.ToInt32(cellTableNumberValue);
        }

        private void UpdateOrdersGridView()
        {            
            OrdersGridView.DataSource = _listAllOrdersController.Execute();
            OrdersGridView.Refresh();
            SetGridViewSettings();

            LastGridViewUpdateLabel.Text = DateTime.Now.ToString();
        }

        private object GetSelectedRowCellValue(int cellIndex)
        {
            if (OrdersGridView.Rows.Count is 0) return default;

            int rowIndex = OrdersGridView.CurrentRow.Index;
            return OrdersGridView.Rows[rowIndex].Cells[cellIndex].Value;
        }

        private void SetGridViewSettings()
        {
            if (OrdersGridView.Rows.Count == 0) return;

            OrdersGridView.Columns[0].Visible = false;

            OrdersGridView.Columns[1].HeaderText = "Nº Comanda";
            OrdersGridView.Columns[2].HeaderText = "Nº Mesa";
            OrdersGridView.Columns[3].HeaderText = "Status";
            OrdersGridView.Columns[4].HeaderText = "Data abertura";
            OrdersGridView.Columns[5].HeaderText = "Data fechamento";
        }
    }
}
