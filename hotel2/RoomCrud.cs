using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace hotel2
{
    class RoomCrud
    {
        public string connString = "Data Source=desktop-5vnkcbq;Initial Catalog=hotel2;Integrated Security=True";
        //public string NumRooms;
        //public string Price;
        //public string Quality;

        public string TableName;

       // database db = new database(); ishledi sora aglatdi meni :( imkan vermedi db clasi yazim sebebin oyredim niye ama elimden qaca bilmezsen :)

        public RoomCrud(string tbName)
        {
            TableName = tbName;

        }

        public void insert(string capacity, string price, string isempty, string floor)
        {

            //    string query = "INSERT INTO " + TableName + " (floor, room_type_id, capacity, price, is_empty) VALUES(@floor, @room_type_id, @capacity, @price, @is_empty)";
            //    using (SqlConnection conn = new SqlConnection(connString))
            //    {
            //        using (SqlCommand command = new SqlCommand(query, conn))
            //        {
            //            command.Parameters.AddWithValue("@floor", floor);
            //            command.Parameters.AddWithValue("@room_type_id", "1");
            //            command.Parameters.AddWithValue("@capacity", capacity);
            //            command.Parameters.AddWithValue("@price", price);
            //            command.Parameters.AddWithValue("@is_empty", isempty);

            //            try
            //            {
            //                conn.Open();
            //                command.ExecuteNonQuery();
            //                conn.Close();
            //            }
            //            catch (SqlException e)
            //            {
            //                MessageBox.Show(e.Message);
            //            }
            //        }
            //    }
        }

        public void delete(int id)
        {
            //string query = "DELETE FROM " + TableName + " WHERE id=@id";
            //using (SqlConnection conn = new SqlConnection(connString))
            //{
            //    using (SqlCommand command = new SqlCommand(query, conn))
            //    {
            //        command.Parameters.AddWithValue("@id", id);
            //        try
            //        {
            //            conn.Open();
            //            command.ExecuteNonQuery();
            //            conn.Close();
            //        }
            //        catch (SqlException e)
            //        {
            //            MessageBox.Show(e.Message);
            //        }
            //    }
            //}

        }

        public void update(int id, string capacity, string price, string isempty, string floor)
        {
            string query = "UPDATE " + TableName + " SET floor=@floor, capacity=@capacity, price=@price, is_empty=@is_empty WHERE id=@id";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@floor", floor);
                    command.Parameters.AddWithValue("@capacity", capacity);
                    command.Parameters.AddWithValue("@price", price);
                    command.Parameters.AddWithValue("@is_empty", isempty);

                    try
                    {
                        conn.Open();
                        command.ExecuteNonQuery();
                        conn.Close();

                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
            }
        }
    }
}
