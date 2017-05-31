using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            string direction = (sender as Button).Text;
            this.Hide();

            if (direction == "Room")
            {
                Room room = new Room();
                room.Closed += (s, args) => this.Close();
                room.Show();
            }
            else if(direction == "Reservation")
            {
                Reserve room = new Reserve();
                room.Closed += (s, args) => this.Close();
                room.Show();
                
            }
            //closed for now
           // else if(direction == "User")
            //{
                //User room = new User();
                //room.Closed += (s, args) => this.Close();
                //room.Show();
           // }
          //  else if(direction == "Food")
          //  {
                //Food room = new Food();
                //room.Closed += (s, args) => this.Close();
                //room.Show();
          //  }


        }
    }
}
