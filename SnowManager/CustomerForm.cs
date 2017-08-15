using System;
using System.Windows.Forms;

namespace SnowManager
{
    public partial class CustomerForm : Form
    {
        Person actualPerson;

        public CustomerForm(Person person)
        {
            InitializeComponent();
            actualPerson = person;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            actualPerson.name = nameBox.Text;
            actualPerson.address = addressBox.Text;
            actualPerson.phone = phoneBox.Text;
            actualPerson.email = emailBox.Text;
            actualPerson.personalID = idBox.Text;
            actualPerson.birth = birthDate.Value.ToShortDateString();

            if (actualPerson.id.Equals(0))
            {
                actualPerson.StorePerson();
            } else
            {
                actualPerson.UpdatePerson();
            }
        }
    }
}
