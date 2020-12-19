using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataLayer.TableDataGateway
{
    public class ZnamkaGateway
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

                    string sql = "SELECT * FROM Znamka";
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

                    string sql = "SELECT * FROM Znamka WHERE Znamka.znamka_id = @id";
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
                Console.WriteLine("Couldnt find the znamka with given ID");
            }

            return dt;
        }

        // returns int, cuz obj actually needs its ID to be updated once its inserted into the DB 
        public int Insert(int znamka, string popis, int studuje_id)
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
                    sb.Append("INSERT INTO Znamka VALUES(@znamka, @popis, @studuje_id)");


                    string sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@znamka", znamka);
                        command.Parameters.AddWithValue("@popis", popis);
                        command.Parameters.AddWithValue("@studuje_id", studuje_id);
                        command.ExecuteScalar();
                    }
                    sql = "SELECT TOP 1 z.znamka_id FROM Znamka z ORDER BY z.znamka_id DESC";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        id = Convert.ToInt32(command.ExecuteScalar());
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Couldnt INSERT znamka into the DB" + e.Message);
            }

            return id;
        }

        public void Update(int id, int znamka, string popis, int studuje_id) //we have to pass ID here, since were updating (we need specific ID to update)
        {

            try
            {
                SqlConnectionStringBuilder builder = DBConnector.GetBuilder();
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    string sql = "UPDATE Student SET znamka = @znamka, popis = @popis, studuje_id = @studuje_id WHERE znamka_id = @id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@jmeno", znamka);
                        command.Parameters.AddWithValue("@prijmeni", popis);
                        command.Parameters.AddWithValue("@email", studuje_id);
                        command.ExecuteScalar();
                    }

                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Couldnt UPDATE znamka in the DB" + e.Message);
            }

        }
    }
}
