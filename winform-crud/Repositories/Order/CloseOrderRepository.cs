using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using winform_crud.Models;

namespace winform_crud.Repositories.Order
{
    public class CloseOrderRepository : BaseRepository
    {
        private const string ID = "@Id";
        private const string STATUS = "@Status";
        private const string CLOSING_DATE = "@DataFechamento";

        public CloseOrderRepository()
        {
            commandQuery = @"UPDATE Comandas SET Status=@Status, DataFechamento=@DataFechamento
                WHERE Id=@Id";
        }

        public void Execute(OrderModel orderModel)
        {
            try
            {
                using SqlCommand sqlCommand = new SqlCommand(commandQuery, OpenConnection());
                sqlCommand.Parameters.AddRange(BuildParameters(orderModel).ToArray());
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

        public List<SqlParameter> BuildParameters(OrderModel orderModel)
        {
            return new List<SqlParameter>
            {
                new SqlParameter(ID, orderModel.Id),
                new SqlParameter(STATUS, orderModel.Status),
                new SqlParameter(CLOSING_DATE, orderModel.ClosingDate)
            };
        }
    }
}
