using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using winform_crud.Models;

namespace winform_crud.Repositories.Client
{
    public class AddOrderRepository : BaseRepository
    {
        private const string ID = "@Id";
        private const string TABLE_ID = "@MesaId";
        private const string NUMBER = "@Numero";
        private const string STATUS = "@Status";
        private const string OPEN_DATE = "@DataAbertura";

        public AddOrderRepository()
        {
            commandQuery = "INSERT INTO Comandas VALUES (@Id, @MesaId, @Numero, @Status, @DataAbertura, NULL)";
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
                new SqlParameter(TABLE_ID, orderModel.TableId),
                new SqlParameter(NUMBER, orderModel.Number),
                new SqlParameter(STATUS, orderModel.Status),
                new SqlParameter(OPEN_DATE, orderModel.OpenDate)
            };
        }
    }
}
