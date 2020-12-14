using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using winform_crud.Models;

namespace winform_crud.Repositories.OrderItems
{
    public class AddOrderItemRepository : BaseRepository
    {
        private const string ID = "@Id";
        private const string PRODUCT_ID = "@ProdutoId";
        private const string ORDER_ID = "@ComandaId";
        private const string ORDER_DATE = "@DataPedido";

        public AddOrderItemRepository()
        {
            commandQuery = @"INSERT INTO PedidosComanda VALUES (
                @Id,
	            @ProdutoId,
	            @ComandaId,
	            @DataPedido)";
        }

        public void Execute(OrderItemModel orderItemModel)
        {
            try
            {
                using SqlCommand sqlCommand = new SqlCommand(commandQuery, OpenConnection());
                sqlCommand.Parameters.AddRange(BuildParameters(orderItemModel).ToArray());
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public List<SqlParameter> BuildParameters(OrderItemModel orderItemModel)
        {
            return new List<SqlParameter>
            {
                new SqlParameter(ID, orderItemModel.Id),
                new SqlParameter(PRODUCT_ID, orderItemModel.ProductId),
                new SqlParameter(ORDER_ID, orderItemModel.OrderId),
                new SqlParameter(ORDER_DATE, orderItemModel.OrderDate)
            };
        }
    }
}
