using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using winform_crud.Responses.Order;

namespace winform_crud.Repositories.Client
{
    public class ListAllOrdersRepository : BaseRepository
    {
        private const string ID = "Id";
        private const string ORDER_NUMBER = "NumeroComanda";
        private const string TABLE_NUMBER = "NumeroMesa";
        private const string STATUS = "Status";
        private const string OPEN_DATE = "DataAbertura";
        private const string CLOSING_DATE = "DataFechamento";

        public ListAllOrdersRepository()
        {
            commandQuery = @"SELECT c.Id, c.Numero as NumeroComanda, m.Numero AS NumeroMesa, c.Status, c.DataAbertura, c.DataFechamento
                FROM Comandas c 
                INNER JOIN Mesas m ON m.Id = c.MesaId
                ORDER BY DataAbertura DESC";
        }

        public List<OrderDTO> Execute()
        {
            try
            {
                using SqlCommand sqlCommand = new SqlCommand(commandQuery, OpenConnection());
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

        private List<OrderDTO> BuildResponse(SqlDataReader sqlDataReader)
        {
            if (!sqlDataReader.HasRows) return default;

            var orders = new List<OrderDTO>();

            while (sqlDataReader.Read())
            {
                orders.Add(new OrderDTO(
                   GuidFrom(sqlDataReader, ID),
                   StringFrom(sqlDataReader, ORDER_NUMBER),
                   StringFrom(sqlDataReader, TABLE_NUMBER),
                   EOrderStatusFrom(sqlDataReader, STATUS),
                   DateFrom(sqlDataReader, OPEN_DATE),
                   NullableDateFrom(sqlDataReader, CLOSING_DATE)                   
                ));
            }

            return orders;
        }
    }
}
