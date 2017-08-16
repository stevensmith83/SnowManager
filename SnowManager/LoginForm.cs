using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnowManager
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(usernameBox.Text.Equals(string.Empty) || passwordBox.Text.Equals(string.Empty))
            {
                MessageBox.Show("Felhasználónév és jelszó megadása szükséges!");
                return;
            }

            try
            {
                DBConnector dbc = new DBConnector();
                if (dbc.CheckLogin(usernameBox.Text, passwordBox.Text))
                {
                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Sikertelen belépés");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }
    }
}
