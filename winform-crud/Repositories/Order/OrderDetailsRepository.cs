using System;
using System.Data.SqlClient;
using winform_crud.DTO.Order;

namespace winform_crud.Repositories.Order
{
    public class OrderDetailsRepository : BaseRepository
    {
        private const string ID = "Id";
        private const string TABLE_ID = "MesaId";
        private const string TABLE_NUMBER = "NumeroMesa";
        private const string ORDER_NUMBER = "NumeroPedido";
        private const string STATUS = "Status";
        private const string OPEN_DATE = "DataAbertura";
        private const string CLOSING_DATE = "DataFechamento";

        public OrderDetailsRepository()
        {
            commandQuery = @"SELECT c.Id, c.MesaId, c.Status, c.Numero AS NumeroPedido, m.Numero AS NumeroMesa, c.DataAbertura, c.DataFechamento 
                FROM Comandas c
                INNER JOIN Mesas m ON m.Id = c.MesaId
                WHERE c.Id = @Id";
        }

        public OrderDetailsDTO Execute(Guid id)
        {
            try
            {
                using SqlCommand sqlCommand = new SqlCommand(commandQuery, OpenConnection());
                sqlCommand.Parameters.AddWithValue("@Id", id);
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

        private OrderDetailsDTO BuildResponse(SqlDataReader sqlDataReader)
        {
            if (!sqlDataReader.HasRows) return default;

            OrderDetailsDTO orderDetailsDTO = new OrderDetailsDTO();

            while (sqlDataReader.Read())
            {
                orderDetailsDTO.Id = GuidFrom(sqlDataReader, ID);
                orderDetailsDTO.TableId = GuidFrom(sqlDataReader, TABLE_ID);
                orderDetailsDTO.TableNumber = StringFrom(sqlDataReader, TABLE_NUMBER);
                orderDetailsDTO.OrderNumber = StringFrom(sqlDataReader, ORDER_NUMBER);
                orderDetailsDTO.Status = EOrderStatusFrom(sqlDataReader, STATUS);
                orderDetailsDTO.OpenDate = DateFrom(sqlDataReader, OPEN_DATE);
                orderDetailsDTO.ClosingDate = NullableDateFrom(sqlDataReader, CLOSING_DATE);
            }

            return orderDetailsDTO;
        }
    }
}
