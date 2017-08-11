using System;
using System.Data.SQLite;

namespace SnowManager
{
    public class DBConnector
    {
        protected SQLiteConnection connection;
        SQLiteTransaction transaction;
        protected SQLiteCommand command;
        //SQLiteCommandBuilder sqlCommand;
        //SQLiteDataAdapter sqlAdapter;

        public DBConnector()
        {
            string connectionString = Properties.Settings.Default.connectionString;
            connection = new SQLiteConnection(connectionString);
        }

        public void OpenConnection()
        {
            connection.Close();
            connection.Open();
            transaction = connection.BeginTransaction();
        }

        public void CloseConnection()
        {
            transaction.Commit();
            connection.Close();
        }

        public void ErrorTransaction()
        {
            transaction.Rollback();
            connection.Close();
        }

        protected int GetNextID(string table)
        {
            command = new SQLiteCommand("SELECT seq FROM SQLITE_SEQUENCE WHERE name='" + table + "'", connection);
            OpenConnection();
            object nextID = command.ExecuteScalar();
            CloseConnection();

            return nextID == DBNull.Value ? 1 : Convert.ToInt32(nextID) + 1;
        }
    }
}