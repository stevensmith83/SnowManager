using System;
using System.Data.SQLite;

namespace SnowManager
{
    public class Person : DBConnector
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string personalID { get; set; }
        public string birth { get; set; }

        public void StorePerson()
        {
            id = GetNextID("person");
            command = new SQLiteCommand("INSERT INTO person (id, name, address, phone, email, personalID, birth) VALUES (?,?,?,?,?,?,?)", connection);
            command.Parameters.AddWithValue("id", id);
            command.Parameters.AddWithValue("name", name);
            command.Parameters.AddWithValue("address", address);
            command.Parameters.AddWithValue("phone", phone);
            command.Parameters.AddWithValue("email", email);
            command.Parameters.AddWithValue("personalID", personalID);
            command.Parameters.AddWithValue("birth", birth);

            try
            {
                OpenConnection();
                command.ExecuteNonQuery();
                CloseConnection();
            }
            catch (Exception ex)
            {
                ErrorTransaction();
                throw new Exception(ex.Message);
            }
        }

        public void UpdatePerson()
        {
            command = new SQLiteCommand("UPDATE person SET name = ?, address = ?, phone = ?, email = ?, personalID = ?, birth = ? WHERE id = ?", connection);
            command.Parameters.AddWithValue("name", name);
            command.Parameters.AddWithValue("address", address);
            command.Parameters.AddWithValue("phone", phone);
            command.Parameters.AddWithValue("email", email);
            command.Parameters.AddWithValue("personalID", personalID);
            command.Parameters.AddWithValue("birth", birth);
            command.Parameters.AddWithValue("id", id);

            try
            {
                OpenConnection();
                command.ExecuteNonQuery();
                CloseConnection();
            }
            catch (Exception ex)
            {
                ErrorTransaction();
                throw new Exception(ex.Message);
            }
        }
    }
}
