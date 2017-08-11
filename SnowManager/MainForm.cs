using ComponentFactory.Krypton.Navigator;
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
            KryptonPage newPage = new KryptonPage(((ComponentFactory.Krypton.Toolkit.KryptonButton)sender).Text);
            mainNavigator.Pages.Add(newPage);
            mainNavigator.SelectedPage = newPage;
            newPage.Dock = DockStyle.Fill;

            
            Form newForm = new Form();
            newForm.TopLevel = false;
            newPage.Controls.Add(newForm);
            newForm.Dock = DockStyle.Fill;
            newForm.Show();
        }
    }
}
