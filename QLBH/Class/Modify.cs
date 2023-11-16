using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace QLBH.Class
{
    internal class Modify
    {
        SqlCommand sqlCommand;
        SqlDataReader dataReader;
        public Modify()
        { 

        }
        public List<TaiKhoan> TaiKhoans(string query)
        {
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
            using(SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while(dataReader.Read())
                {
                    taiKhoans.Add(new TaiKhoan(dataReader.GetString(0),dataReader.GetString(1)));
                }
                sqlConnection.Close();
            }
            return taiKhoans;
        }
    }
}
