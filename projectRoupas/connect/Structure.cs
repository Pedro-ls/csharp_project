using System;
using System.Data;
using System.Data.SqlClient;


namespace projectRoupas.connect
{
    class Structure
    {
        public static DataTable query(String sql)
        {

            SqlDataAdapter sqlAdapter;

            DataTable data = new DataTable();
            var connection = new Connection().getConnection();
            var obj = connection.CreateCommand();

            obj.CommandText = sql;

            sqlAdapter = (new SqlDataAdapter(obj.CommandText, connection));

            sqlAdapter.Fill(data);

            connection.Close();
           
            return data;


        }
    }
}
