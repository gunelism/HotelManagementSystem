using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace hotel2
{
    public partial class User : Form
    {
        public int Id;
        //public string Name;
        //public string SurName;
        //public string Phone;
        //public string Birthdate;

        database db = new database();

        public User()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotel2DataSet4.guest' table. You can move, or remove it, as needed.
            this.guestTableAdapter.Fill(this.hotel2DataSet4.guest);
            // TODO: This line of code loads data into the 'hotel2DataSet3.user' table. You can move, or remove it, as needed.
            // this.userTableAdapter.Fill(this.hotel2DataSet3.user);
            // TODO: This line of code loads data into the 'hotel2DataSet2.room' table. You can move, or remove it, as needed.
            //this.roomTableAdapter.Fill(this.hotel2DataSet2.room);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> datas = new Dictionary<string, string>();
            datas.Add("name", txtName.Text);
            datas.Add("surname", txtSurname.Text);
            datas.Add("phone", txtPhone.Text);

            db.Insert("guest", datas);
            User_Load(this, null);
              
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
           // Id = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
           // Id = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
           // Id = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
           // Id = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());


        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            db.DeleteId(Id, "guest");
            User_Load(this, null);
        }

        //yeni ki adam bu user secir reserve ucun;
        public int IdReverse;
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IdReverse = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
            string NameReserve = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();

            this.Close();
            Reserve us = new Reserve(IdReverse, NameReserve);
            //us.userData(IdReverse, NameReserve);

          
        }
    }
}
