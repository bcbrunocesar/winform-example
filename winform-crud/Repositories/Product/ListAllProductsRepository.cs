using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using winform_crud.DTO.Product;

namespace winform_crud.Repositories.Product
{
    public class ListAllProductsRepository : BaseRepository
    {
        private const string ID = "Id";
        private const string NAME = "Nome";
        private const string PRICE = "Preco";

        public ListAllProductsRepository()
        {
            commandQuery = @"SELECT p.Id, p.Nome, p.Preco FROM Produtos p WHERE Status = 1 ORDER BY Nome";
        }

        public List<ProductDTO> Execute()
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

        private List<ProductDTO> BuildResponse(SqlDataReader sqlDataReader)
        {
            if (!sqlDataReader.HasRows) return default;

            var products = new List<ProductDTO>();

            while (sqlDataReader.Read())
            {
                products.Add(new ProductDTO(
                   GuidFrom(sqlDataReader, ID),
                   StringFrom(sqlDataReader, NAME),
                   DoubleFrom(sqlDataReader, PRICE)
                ));
            }

            return products;
        }
    }
}
