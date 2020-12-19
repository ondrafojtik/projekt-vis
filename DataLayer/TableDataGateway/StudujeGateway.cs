using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataLayer.TableDataGateway
{
    public class StudujeGateway
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

                    string sql = "SELECT * FROM Studuje";
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

                    string sql = "SELECT * FROM Studuje WHERE Studuje.studuje_id = @id";
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
                Console.WriteLine("Couldnt find the studuje with given ID");
            }

            return dt;
        }

        // returns int, cuz obj actually needs its ID to be updated once its inserted into the DB 
        public int Insert(int student_id, int predmet_id)
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
                    sb.Append("INSERT INTO Studuje VALUES(@student_id, @predmet_id)");


                    string sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@student_id", student_id);
                        command.Parameters.AddWithValue("@predmet_id", predmet_id);
                        command.ExecuteScalar();
                    }
                    sql = "SELECT TOP 1 s.studuje_id FROM Studuje s ORDER BY s.studuje_id DESC";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        id = Convert.ToInt32(command.ExecuteScalar());
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Couldnt INSERT studuje into the DB" + e.Message);
            }

            return id;
        }

        public void Update(int id, int student_id, int predmet_id) //we have to pass ID here, since were updating (we need specific ID to update)
        {

            try
            {
                SqlConnectionStringBuilder builder = DBConnector.GetBuilder();
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    string sql = "UPDATE Predmet SET student_id = @student_id, predmet_id = @predmet_id WHERE studuje_id = @id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@student_id", student_id);
                        command.Parameters.AddWithValue("@predmet_id", predmet_id);
                        command.ExecuteScalar();
                    }

                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Couldnt UPDATE studuje in the DB" + e.Message);
            }
        }
    
    }
}
