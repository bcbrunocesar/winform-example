using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using winform_crud.Controllers.OrderItem;
using winform_crud.DTO.Order;
using winform_crud.DTO.OrderItems;
using winform_crud.Controllers.Product;
using winform_crud.Models;

namespace winform_crud.Views.OrderItem
{
    public partial class OrderItemDetailsView : BaseView
    {
        private Guid _orderId;
        private List<OrderItemDTO> _orderItems;

        private readonly OrderDetailsController _orderDetailsController;
        private readonly ListOrderItemsController _listAllOrderItemController;        
        private readonly ListProductController _listProductController;
        private readonly AddOrderItemController _addOrderItemController;

        public OrderItemDetailsView(Guid orderId)
        {
            InitializeComponent();

            _orderId = orderId;
            _orderItems = new List<OrderItemDTO>();

            _orderDetailsController = new OrderDetailsController();
            _listAllOrderItemController = new ListOrderItemsController();            
            _listProductController = new ListProductController();
            _addOrderItemController = new AddOrderItemController();
        }

        private void OrderItemView_Load(object sender, EventArgs e)
        {
            UpdateOrderItemDetailsGridView();
            SetOrderItemDetailsInformation();
            SetProductsComboBox();
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void AddOrderItemButton_Click(object sender, EventArgs e)
        {
            if (AllProductsComboBox.SelectedIndex < 0) return;

            Guid itemId = Guid.Parse(AllProductsComboBox.SelectedValue.ToString());
            OrderItemModel orderItemModel = new OrderItemModel(itemId, _orderId);

            _addOrderItemController.Execute(orderItemModel);

            UpdateOrderItemDetailsGridView();
            SetOrderItemDetailsInformation();
            SetProductsComboBox();
        }

        private void UpdateOrderItemDetailsGridView()
        {
            _orderItems = _listAllOrderItemController.Execute(_orderId);
            SetTotalPrice(_orderItems);

            OrderItemGridView.DataSource = _orderItems;
            OrderItemGridView.Refresh();

            SetGridViewSettings();
        }

        private void SetProductsComboBox()
        {
            AllProductsComboBox.DataSource = _listProductController.Execute();
            AllProductsComboBox.ValueMember = "Id";
            AllProductsComboBox.DisplayMember = "Name";            
            AllProductsComboBox.Refresh();
        }

        private void SetOrderItemDetailsInformation()
        {
            OrderDetailsDTO orderDetailsDTO = _orderDetailsController.Execute(_orderId);

            if (orderDetailsDTO is null) return;

            StatusOrderLabel.Text = orderDetailsDTO.Status.ToString();
            OrderNumberLabel.Text = orderDetailsDTO.OrderNumber;
            TableNumberLabel.Text = orderDetailsDTO.TableNumber;
            OpenDateLabel.Text = orderDetailsDTO.OpenDate.ToString();
            ClosingDateLabel.Text = orderDetailsDTO.ClosingDate.ToString();
        }

        private void SetTotalPrice(List<OrderItemDTO> orderItems)
        {
            if (orderItems is null) return;
            OrderTotalPrice.Text = orderItems.Sum(x => x.ProductPrice).ToString("C");
        }

        private void SetGridViewSettings()
        {
            if (OrderItemGridView.Rows.Count == 0) return;

            OrderItemGridView.Columns[0].Visible =
            OrderItemGridView.Columns[1].Visible =
            OrderItemGridView.Columns[2].Visible = false;

            OrderItemGridView.Columns[3].HeaderText = "Produto";
            OrderItemGridView.Columns[4].HeaderText = "Preço";
            OrderItemGridView.Columns[4].DefaultCellStyle.Format = "C";
            OrderItemGridView.Columns[5].HeaderText = "Data e hora do pedido";
        }
    }
}
