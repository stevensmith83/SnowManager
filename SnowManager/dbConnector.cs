using System;
using System.Security;
using System.Security.Cryptography;
using System.Data.SQLite;

namespace SnowManager
{
    public class DBConnector
    {
        protected SQLiteConnection connection;
        SQLiteTransaction transaction;
        protected SQLiteCommand command;
        byte[] entropy = System.Text.Encoding.Unicode.GetBytes("entropyValue");

        //SQLiteCommandBuilder sqlCommand;
        //SQLiteDataAdapter sqlAdapter;

        public DBConnector()
        {
            string connectionString = "Data Source=" + Properties.Settings.Default.dbSource + ";Version=" + Properties.Settings.Default.dbVersion + ";";

            if (Properties.Settings.Default.dbEncryption)
            {
                connectionString += "Password=" + ToInsecureString(DecryptString(Properties.Settings.Default.dbPassword)) + ";";
            }

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

        public void EncryptDB(string password)
        {
            OpenConnection();
            connection.ChangePassword(password);
            Properties.Settings.Default.dbPassword = EncryptString(ToSecureString(password));
            Properties.Settings.Default.dbEncryption = true;
            CloseConnection();
        }

        public void DecryptDB()
        {
            OpenConnection();
            connection.ChangePassword(string.Empty);
            Properties.Settings.Default.dbPassword = string.Empty;
            Properties.Settings.Default.dbEncryption = false;
            CloseConnection();
        }
                
        private string EncryptString(SecureString input)
        {
            byte[] encryptedData = ProtectedData.Protect(System.Text.Encoding.Unicode.GetBytes(ToInsecureString(input)), entropy, DataProtectionScope.CurrentUser);
            return Convert.ToBase64String(encryptedData);
        }

        private SecureString DecryptString(string encryptedData)
        {
            try
            {
                byte[] decryptedData = ProtectedData.Unprotect(Convert.FromBase64String(encryptedData), entropy, DataProtectionScope.CurrentUser);
                return ToSecureString(System.Text.Encoding.Unicode.GetString(decryptedData));
            }
            catch
            {
                return new SecureString();
            }
        }

        private SecureString ToSecureString(string input)
        {
            SecureString secure = new SecureString();
            foreach (char c in input)
            {
                secure.AppendChar(c);
            }
            secure.MakeReadOnly();
            return secure;
        }

        private string ToInsecureString(SecureString input)
        {
            string returnValue = string.Empty;
            IntPtr ptr = System.Runtime.InteropServices.Marshal.SecureStringToBSTR(input);

            try
            {
                returnValue = System.Runtime.InteropServices.Marshal.PtrToStringBSTR(ptr);
            }
            finally
            {
                System.Runtime.InteropServices.Marshal.ZeroFreeBSTR(ptr);
            }

            return returnValue;
        }
    }
}