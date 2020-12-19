using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataLayer.TableDataGateway
{
    public class ZamestnanecGateway
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

                    string sql = "SELECT * FROM Zamestnanec";
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

                    string sql = "SELECT * FROM Zamestnanec z WHERE z.ucitel_id = @id";
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
                Console.WriteLine("Couldnt find the student with given ID");
            }

            return dt;
        }

        // returns int, cuz obj actually needs its ID to be updated once its inserted into the DB 
        public int Insert(string jmeno, string prijmeni, string email, string telefon, bool reditel)
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
                    sb.Append("INSERT INTO Zamestnanec VALUES(@jmeno, @prijmeni, @email, @telefon, @reditel)");


                    string sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@jmeno", jmeno);
                        command.Parameters.AddWithValue("@prijmeni", prijmeni);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@telefon", telefon);
                        command.Parameters.AddWithValue("@reditel", reditel);
                        command.ExecuteScalar();
                    }
                    sql = "SELECT TOP 1 z.ucitel_id FROM Zamestnanec z ORDER BY z.ucitel_id DESC";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        id = Convert.ToInt32(command.ExecuteScalar());
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Couldnt INSERT Zamestnanec into the DB" + e.Message);
            }

            return id;
        }

        public void Update(int id, string jmeno, string prijmeni, string email, string telefon, bool reditel) //we have to pass ID here, since were updating (we need specific ID to update)
        {

            try
            {
                SqlConnectionStringBuilder builder = DBConnector.GetBuilder();
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    string sql = "UPDATE Zamestnanec SET jmeno = @jmeno, prijmeni = @prijmeni, email = @email, telefon = @telefon, reditel = @reditel WHERE ucitel_id = @id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@jmeno", jmeno);
                        command.Parameters.AddWithValue("@prijmeni", prijmeni);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@telefon", telefon);
                        command.Parameters.AddWithValue("@reditel", reditel);
                        command.ExecuteScalar();
                    }

                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Couldnt UPDATE Zamestnanec in the DB" + e.Message);
            }

        }

    }
}
