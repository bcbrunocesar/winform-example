using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using winform_crud.DTO.Table;

namespace winform_crud.Repositories.Table
{
    public class ListAllTablesRepository : BaseRepository
    {
        private const string ID = "Id";
        private const string NUMBER = "Numero";
        private const string IS_BUSY = "Ocupada";

        public ListAllTablesRepository()
        {
            commandQuery = @"SELECT Id, Numero, 
                    Ocupada = (
			            SELECT C.Status 
			            FROM Comandas C 
                        WHERE C.MesaId = M.Id 
                        AND C.Status = 1)
            FROM Mesas M 
            ORDER BY M.Numero";                                                             
                                                
            //commandQuery = @"SELECT * FROM Mesas 
            // WHERE Id NOT IN(
            //  SELECT m.Id
            //  FROM Comandas c
            //  INNER JOIN Mesas m ON m.Id = c.MesaId
            //  WHERE c.Status = 1
            // )";
        }

        public List<TableDTO> Execute()
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

        private List<TableDTO> BuildResponse(SqlDataReader sqlDataReader)
        {
            if (!sqlDataReader.HasRows) return default;

            var tables = new List<TableDTO>();

            while (sqlDataReader.Read())
            {
                tables.Add(new TableDTO(
                   GuidFrom(sqlDataReader, ID),
                   IntFrom(sqlDataReader, NUMBER),
                   IsTableBusyFrom(sqlDataReader, IS_BUSY)
                ));
            }

            return tables;
        }
    }
}
