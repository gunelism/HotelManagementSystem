using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hotel2
{
    public partial class Room : Form
    {
        public int ID;
        public string Floor;
        public string Capacity;
        public string Price;
        public string IsEmpty;
        public string RoomType;


        RoomCrud rc = new RoomCrud("room");
        database db = new database();

        public Room()
        {
            InitializeComponent();
        }

        private void Room_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotel2DataSet1.room' table. You can move, or remove it, as needed.
            this.roomTableAdapter2.Fill(this.hotel2DataSet1.room);
            // TODO: This line of code loads data into the 'hotel2DataSet.room' table. You can move, or remove it, as needed.
          //  this.roomTableAdapter1.Fill(this.hotel2DataSet.room);
            // TODO: This line of code loads data into the 'test1DataSet.room' table. You can move, or remove it, as needed.
           // this.roomTableAdapter.Fill(this.test1DataSet.room);

            this.cmbRoom.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        //ading data
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string check;
            if (checkEmpty.Checked)            
                check = "1";
            else
                check = "0";

            Dictionary<string, string> datas = new Dictionary<string, string>();
            datas.Add("floor", txtFloor.Text);
            datas.Add("room_type_id", "1");
            datas.Add("capacity", cmbRoom.Text);
            datas.Add("price", txtPrice.Text);
            datas.Add("is_empty", check);

            db.Insert("room", datas);
           // rc.insert(cmbRoom.Text, txtPrice.Text, check, txtFloor.Text);
            Room_Load(this, null);
            clear();
        }


         //getting clicked cell
        private void dataGridView1_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            Floor = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            RoomType = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Capacity = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            Price = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            IsEmpty = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            db.DeleteId(ID, "room");
            Room_Load(this, null);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cmbRoom.Text = Capacity;
            txtPrice.Text = Price;
            txtFloor.Text = Floor;
            if (IsEmpty == "1")
                checkEmpty.Checked = true;
            else
                checkEmpty.Checked = false;
            
        }

        private void btnEditSave_Click(object sender, EventArgs e)
        {
            string check;
            if (checkEmpty.Checked)
                check = "1";
            else
                check = "0";
            rc.update(ID, cmbRoom.Text, txtPrice.Text, check, txtFloor.Text);
            Room_Load(this, null);
            clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                //this.Hide();
                //User us= new User();
                //us.Closed += (s, args) => this.Close();
                //us.Show();
            }
        }

        //helpers
        public void clear()
        {
            cmbRoom.SelectedIndex = -1;
            txtPrice.Text = "";
            txtFloor.Text = "";
            checkEmpty.Checked = false;

        }

        
    }
}
