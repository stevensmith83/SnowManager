using System;
using System.Data;
using System.Windows.Forms;

namespace SnowManager
{
    public partial class CustomerListForm : Form
    {
        Person person = new Person();

        public CustomerListForm()
        {
            InitializeComponent();
            RefreshTable();
        }

        private void RefreshTable()
        {
            DBConnector dbc = new DBConnector();
            customerGrid.DataSource = dbc.GetTable("person").Tables[0];
        }

        private void newCustomer_Click(object sender, EventArgs e)
        {
            person = new Person();
            CustomerForm customerForm = new CustomerForm(person);
            customerForm.ShowDialog();
            RefreshTable();
        }

        private void editCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm(person);
            customerForm.ShowDialog();
            RefreshTable();
        }

        private void deleteCustomer_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Biztos törlöd az ügyfelet?", "Törlés megerősítése", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                person.DeletePerson();
                RefreshTable();
            }
        }

        private void refreshTable_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void customerGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (customerGrid.CurrentRow != null)
            {
                person.id = Convert.ToInt16(customerGrid["id", customerGrid.CurrentRow.Index].Value);
                person.name = customerGrid["name", customerGrid.CurrentRow.Index].Value.ToString();
                person.address = customerGrid["address", customerGrid.CurrentRow.Index].Value.ToString();
                person.phone = customerGrid["phone", customerGrid.CurrentRow.Index].Value.ToString();
                person.email = customerGrid["email", customerGrid.CurrentRow.Index].Value.ToString();
                person.personalID = customerGrid["personalID", customerGrid.CurrentRow.Index].Value.ToString();
                person.birth = customerGrid["birth", customerGrid.CurrentRow.Index].Value.ToString();
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            string field = customerGrid.SortedColumn != null ? customerGrid.SortedColumn.Name : "name";
            (customerGrid.DataSource as DataTable).DefaultView.RowFilter = searchBox.Text.Equals(string.Empty) ? string.Empty : string.Format(field + " LIKE '%{0}%'", searchBox.Text);
        }
    }
}
