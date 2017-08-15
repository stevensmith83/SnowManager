using System;
using System.Windows.Forms;

namespace SnowManager
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            dbFileBox.Text = Properties.Settings.Default.dbSource;
            dbPasswordBox.Text = Properties.Settings.Default.dbPassword;
            dbEncryptCheck.Checked = Properties.Settings.Default.dbEncryption;
        }

        private void dbFileOpen_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                dbFileBox.Text = openFileDialog.FileName;
            }
        }
                
        private void dbPasswordBox_TextChanged(object sender, EventArgs e)
        {
            dbEncryptCheck.Enabled = !dbPasswordBox.Text.Equals(string.Empty);
            dbEncryptCheck.Checked = !dbPasswordBox.Text.Equals(string.Empty);
        }

        private void dbEncryptCheck_CheckedChanged(object sender, EventArgs e)
        {
            dbPasswordBox.Text = !dbEncryptCheck.Checked ? string.Empty : dbPasswordBox.Text;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.dbSource = dbFileBox.Text;
            DBConnector dbc = new DBConnector();

            if (dbEncryptCheck.Checked && !dbPasswordBox.Text.Equals(string.Empty))
            {
                dbc.EncryptDB(dbPasswordBox.Text);
            }
            else
            {
                dbc.DecryptDB();
            }

            dbc = null;
            Properties.Settings.Default.Save();
        }
    }
}
