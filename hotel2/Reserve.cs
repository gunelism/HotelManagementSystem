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
    public partial class Reserve : Form
    {
        public int UserId;

        public Reserve(int id=0, string name=null)
        {
            UserId = id;
            MessageBox.Show(name);
            txtName.Text = name;
            InitializeComponent();
            this.Load += Reserve_Load;
        }

        private void Reserve_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotel2DataSet5.reservation' table. You can move, or remove it, as needed.
            this.reservationTableAdapter.Fill(this.hotel2DataSet5.reservation);
            // TODO: This line of code loads data into the 'test1DataSet1.room_reservation' table. You can move, or remove it, as needed.
            this.room_reservationTableAdapter.Fill(this.test1DataSet1.room_reservation);
      
        }
        //getting user data

        //public void userData()
        //{
            
        //}
        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show(UserId.ToString() + " user selected");

        }

        private void btnSelectUser_Click(object sender, EventArgs e)
        {
            User us = new User();
            us.Show();
        }

        private void btnSelectRoom_Click(object sender, EventArgs e)
        {
            Room ro = new Room();
            ro.Show();
        }
    }
}
