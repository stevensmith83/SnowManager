using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Windows.Forms;

namespace SnowManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AddPage(object sender, EventArgs e)
        {
            string name = ((KryptonButton)sender).Name;
            KryptonPage newPage = new KryptonPage(((KryptonButton)sender).Text);

            mainNavigator.Pages.Add(newPage);
            mainNavigator.SelectedPage = newPage;
            newPage.Dock = DockStyle.Fill;
            Form newForm = null;

            switch (name)
            {
                case ("customerList"): newForm = new CustomerListForm(); break;
                default: newForm = new Form(); break;
            }

            newForm.TopLevel = false;
            newPage.Controls.Add(newForm);
            newForm.Dock = DockStyle.Fill;
            newForm.Show();
        }

        private void newCustomer_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            CustomerForm customerForm = new CustomerForm(person);
            customerForm.ShowDialog();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
