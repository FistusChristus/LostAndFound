using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Gmap_Markers
{
    internal class model
    {
        public void Sort_Db()
        {
            DataTable dt = Select("Select * From MapAd", "MapAd");
            Db_Ad.AdList.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
               
                    Db_Ad fake = new Db_Ad();
                    fake.id= Convert.ToInt32(dt.Rows[i][0]);
                    fake.PointX = Convert.ToInt32(dt.Rows[i][1]);
                    fake.PointY = Convert.ToInt32(dt.Rows[i][2]);
                    fake.Login = dt.Rows[i][3].ToString();
                    fake.Type = Convert.ToBoolean(dt.Rows[i][4]);
                    fake.Category = Convert.ToInt32(dt.Rows[i][5]);
                    fake.Title = dt.Rows[i][6].ToString();
                    fake.ImagePath = dt.Rows[i][7].ToString();
                    fake.description = dt.Rows[i][8].ToString();
                    fake.Add_Obj();
            }

        }
        public void delete(string selectSQL)
        {
            using (SqlConnection connection = new SqlConnection("server=COMPUTER\\SQLEXPRESS01;Database=Ad;Trusted_Connection=Yes;"))
            {

                DataTable dataTable = new DataTable("MapAd");

                SqlConnection conn = new SqlConnection("server=COMPUTER\\SQLEXPRESS01;Database=Ad;Trusted_Connection=Yes;");
                connection.Open();

                SqlCommand command = conn.CreateCommand();
                command.CommandText = selectSQL;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);

                connection.Close();
                //return dataTable;
            }
        }
        public void AddPointInDb(string selectSQL)
        {
            using (SqlConnection connection = new SqlConnection("server=COMPUTER\\SQLEXPRESS01;Database=Ad;Trusted_Connection=Yes;"))
            {

                DataTable dataTable = new DataTable("MapAd");

                SqlConnection conn = new SqlConnection("server=COMPUTER\\SQLEXPRESS01;Database=Ad;Trusted_Connection=Yes;");
                connection.Open();

                SqlCommand command = conn.CreateCommand();
                command.CommandText = selectSQL;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);

                connection.Close();
                //return dataTable;
            }
        }
        public DataTable Select(string selectSQL, string tableName)
        {
            DataTable dataTable = new DataTable(tableName);

            SqlConnection connection = new SqlConnection("server=COMPUTER\\SQLEXPRESS01;Database=Ad;Trusted_Connection=Yes;");
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandText = selectSQL;        

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);

            connection.Close();
            return dataTable;
        }
    }
}
