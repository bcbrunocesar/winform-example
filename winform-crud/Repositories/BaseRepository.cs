using System;
using System.Data.SqlClient;
using winform_crud.Database;
using winform_crud.Models;

namespace winform_crud.Repositories
{
    public abstract class BaseRepository : DatabaseSettings
    {
        protected Guid GuidFrom(SqlDataReader sqlDataReader, string parameterName)
        {
            return Guid.Parse(sqlDataReader[parameterName].ToString());
        }

        protected string StringFrom(SqlDataReader sqlDataReader, string parameterName)
        {
            return sqlDataReader[parameterName].ToString();
        }

        protected int IntFrom(SqlDataReader sqlDataReader, string parameterName)
        {
            return Convert.ToInt32(sqlDataReader[parameterName]);
        }

        protected double DoubleFrom(SqlDataReader sqlDataReader, string parameterName)
        {
            return Convert.ToDouble(sqlDataReader[parameterName]);
        }

        protected DateTime DateFrom(SqlDataReader sqlDataReader, string parameterName)
        {
            return Convert.ToDateTime(sqlDataReader[parameterName]);
        }

        protected DateTime? NullableDateFrom(SqlDataReader sqlDataReader, string parameterName)
        {
            bool isDate = DateTime.TryParse(sqlDataReader[parameterName].ToString(), out DateTime output);
            return isDate
                ? output
                : (DateTime?)null;
        }

        protected EOrderStatus EOrderStatusFrom(SqlDataReader sqlDataReader, string parameterName)
        {
            return (EOrderStatus)Convert.ToInt16(sqlDataReader[parameterName]);
        }

        protected bool IsTableBusyFrom(SqlDataReader sqlDataReader, string parameterName)
        {
            return sqlDataReader[parameterName].ToString().Equals("1");
        }
    }
}
