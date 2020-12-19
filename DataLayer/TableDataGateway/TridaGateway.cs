using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataLayer.TableDataGateway
{
    public class TridaGateway
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

                    string sql = "SELECT * FROM Trida";
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

                    string sql = "SELECT * FROM Trida t WHERE t.trida_id = @id";
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
                Console.WriteLine("Couldnt find the Trida with given ID");
            }

            return dt;
        }

        // returns int, cuz obj actually needs its ID to be updated once its inserted into the DB 
        public int Insert(string jmeno_tridy, int ucitel_id)
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
                    sb.Append("INSERT INTO Trida VALUES(@jmeno_tridy, @ucitel_id)");


                    string sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@jmeno_tridy", jmeno_tridy);
                        command.Parameters.AddWithValue("@ucitel_id", ucitel_id);
                        command.ExecuteScalar();
                    }
                    sql = "SELECT TOP 1 t.trida_id FROM Trida t ORDER BY t.trida_id DESC";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        id = Convert.ToInt32(command.ExecuteScalar());
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Couldnt INSERT Trida into the DB" + e.Message);
            }

            return id;
        }

        public void Update(int id, string jmeno_tridy, int ucitel_id) //we have to pass ID here, since were updating (we need specific ID to update)
        {

            try
            {
                SqlConnectionStringBuilder builder = DBConnector.GetBuilder();
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    string sql = "UPDATE Trida SET jmeno_tridy = @jmeno_tridy, ucitel_id = @ucitel_id WHERE trida_id = @id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@jmeno_tridy", jmeno_tridy);
                        command.Parameters.AddWithValue("@ucitel_id", ucitel_id);
                        command.ExecuteScalar();
                    }

                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Couldnt UPDATE Trida in the DB" + e.Message);
            }

        }

    }
}
