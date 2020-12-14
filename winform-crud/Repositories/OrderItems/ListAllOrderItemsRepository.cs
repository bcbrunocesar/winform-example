using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using winform_crud.DTO.OrderItems;

namespace winform_crud.Repositories.OrderItems
{
    public class ListAllOrderItemsRepository : BaseRepository
    {
        private const string ID = "Id";
        private const string PRODUCT_ID = "ProdutoId";
        private const string ORDER_ID = "ComandaId";
        private const string PRODUCT_NAME = "Nome";
        private const string PRODUCT_PRICE = "Preco";
        private const string ORDER_DATE = "DataPedido";

        public ListAllOrderItemsRepository()
        {
            commandQuery = @"SELECT pc.Id, pc.ProdutoId, pc.ComandaId, pc.DataPedido, p.Nome, p.Preco
                FROM PedidosComanda pc
                INNER JOIN Produtos p ON p.Id = pc.ProdutoId
                INNER JOIN Comandas c ON c.Id = pc.ComandaId
                WHERE pc.ComandaId = @OrderId";
        }

        public List<OrderItemDTO> Execute(Guid orderId)
        {
            try
            {
                using SqlCommand sqlCommand = new SqlCommand(commandQuery, OpenConnection());
                sqlCommand.Parameters.AddWithValue("@OrderId", orderId);
                return BuildResponse(sqlCommand.ExecuteReader());
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                return default;
            }
            finally
            {
                CloseConnection();
            }
        }

        private List<OrderItemDTO> BuildResponse(SqlDataReader sqlDataReader)
        {
            if (!sqlDataReader.HasRows) return default;

            var orderItems = new List<OrderItemDTO>();

            while (sqlDataReader.Read())
            {
                orderItems.Add(new OrderItemDTO(
                   GuidFrom(sqlDataReader, ID),
                   GuidFrom(sqlDataReader, PRODUCT_ID),
                   GuidFrom(sqlDataReader, ORDER_ID),
                   StringFrom(sqlDataReader, PRODUCT_NAME),
                   DoubleFrom(sqlDataReader, PRODUCT_PRICE),
                   DateFrom(sqlDataReader, ORDER_DATE)
                ));
            }

            return orderItems;
        }
    }
}
