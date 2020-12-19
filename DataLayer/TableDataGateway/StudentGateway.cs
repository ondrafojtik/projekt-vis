using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataLayer.TableDataGateway
{
    public class StudentGateway
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

                    string sql = "SELECT * FROM Student";
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

                    string sql = "SELECT * FROM Student WHERE Student.student_id = @id";
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

            if (dt.Rows.Count == 0)
                Console.WriteLine("Student with given ID doesnt exist");

            return dt;
        }

        // returns int, cuz obj actually needs its ID to be updated once its inserted into the DB 
        public int Insert(string jmeno, string prijmeni, string email, string email_rodice, string telefon_rodice, int trida_id)
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
                    sb.Append("INSERT INTO Student VALUES(@jmeno, @prijmeni, @email, @email_rodice, @telefon_rodice, @trida_id)");
                   

                    string sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@jmeno", jmeno);
                        command.Parameters.AddWithValue("@prijmeni", prijmeni);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@email_rodice", email_rodice);
                        command.Parameters.AddWithValue("@telefon_rodice", telefon_rodice);
                        command.Parameters.AddWithValue("@trida_id", trida_id);
                        command.ExecuteScalar();
                    }
                    sql = "SELECT TOP 1 s.student_id FROM Student s ORDER BY s.student_id DESC";
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

        public void Update(int id, string jmeno, string prijmeni, string email, string email_rodice, string telefon_rodice, int trida_id) //we have to pass ID here, since were updating (we need specific ID to update)
        {

            try
            {
                SqlConnectionStringBuilder builder = DBConnector.GetBuilder();
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    string sql = "UPDATE Student SET jmeno = @jmeno, prijmeni = @prijmeni, email = @email, Email_rodice = @email_rodice, " +
                    "Telefon_rodice = @telefon_rodice, trida_id = @trida_id WHERE student_id = @id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@jmeno", jmeno);
                        command.Parameters.AddWithValue("@prijmeni", prijmeni);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@email_rodice", email_rodice);
                        command.Parameters.AddWithValue("@telefon_rodice", telefon_rodice);
                        command.Parameters.AddWithValue("@trida_id", trida_id);
                        command.ExecuteScalar();
                    }
                    
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Couldnt UPDATE student in the DB" + e.Message);
            }

        }

    }
}
