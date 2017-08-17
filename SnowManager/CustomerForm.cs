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

            if (!actualPerson.id.Equals(0))
            {
                nameBox.Text = actualPerson.name;
                addressBox.Text = actualPerson.address;
                phoneBox.Text = actualPerson.phone;
                emailBox.Text = actualPerson.email;
                idBox.Text = actualPerson.personalID;
                birthDate.Value = DateTime.Parse(actualPerson.birth);
            }
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
