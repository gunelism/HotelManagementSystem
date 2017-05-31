using System;
using System.Windows.Forms;

namespace hotel2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnLog_Click_1(object sender, EventArgs e)
        {
            Person logPerson = new Person(txtName.Text, txtSurname.Text, "adminLog");

            if (logPerson.select() == 1)
            {
                this.Hide();
                Menu menu = new Menu();
                menu.Closed += (s, args) => this.Close();
                menu.Show();
            }
            else
                MessageBox.Show("Write you'r info correctly please");
        }
    }
}
