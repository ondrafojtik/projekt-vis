using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataLayer.TableDataGateway
{
    public class PredmetGateway
    {

        public DataTable Find()
        {
            DataTable dt = new DataTable();
            SqlConnectionStringBuilder builder = DBConnector.GetBuilder();
            try
            {
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM Predmet";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine("Couldnt connect to the DB");
            }

            return dt;
        }

        public DataTable FindByID(int id)
        {
            DataTable dt = new DataTable();
            SqlConnectionStringBuilder builder = DBConnector.GetBuilder();
            try
            {
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM Predmet WHERE Predmet.predmet_id = @id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine("Couldnt find the predmet with given ID");
            }

            return dt;
        }

        // returns int, cuz obj actually needs its ID to be updated once its inserted into the DB 
        public int Insert(string jmeno)
        {
            int id = -1;

            try
            {
                SqlConnectionStringBuilder builder = DBConnector.GetBuilder();
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.Clear();
                    sb.Append("INSERT INTO Predmet VALUES(@jmeno)");


                    string sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@jmeno", jmeno);
                        command.ExecuteScalar();
                    }
                    sql = "SELECT TOP 1 p.predmet_id FROM Predmet p ORDER BY p.predmet_it DESC";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        id = Convert.ToInt32(command.ExecuteScalar());
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Couldnt INSERT student into the DB" + e.Message);
            }

            return id;
        }

        public void Update(int id, string jmeno) //we have to pass ID here, since were updating (we need specific ID to update)
        {

            try
            {
                SqlConnectionStringBuilder builder = DBConnector.GetBuilder();
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    string sql = "UPDATE Predmet SET jmeno = @jmeno WHERE predmet_id = @id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@jmeno", jmeno);
                        command.ExecuteScalar();
                    }

                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Couldnt UPDATE predmet in the DB" + e.Message);
            }
        }
    }
}
