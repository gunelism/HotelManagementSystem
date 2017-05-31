using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hotel2
{
    class database
    {
        public SqlConnection conn;
        //public string tableName;

        public database()
        {
           // SqlConnection conn = new SqlConnection("Data Source=desktop-5vnkcbq;Initial Catalog=hotel2;Integrated Security=True");
            //this.conn = conn;
            try
            {
                string str = "Data Source=desktop-5vnkcbq;database=hotel2;Integrated Security=True";
                SqlConnection con = new SqlConnection(str);
                this.conn = con;
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            // connectionOpen();
            //tableName = tableN;
        }
        public void connectionOpen()
        {
            conn.Open();
        }

        public void connectionClose()
        {
            conn.Close();
        }

        public void Insert(string table, Dictionary<string, string> datas)
        {
            StringBuilder query = new StringBuilder();
            StringBuilder columns = new StringBuilder();
            StringBuilder values = new StringBuilder();

            foreach (var column in datas.Keys)
            {
                columns.Append(column);
                values.Append('@' + column);

                if (!column.Equals(datas.Last().Key))
                {
                    columns.Append(',');
                    values.Append(',');
                }
            }
            
            query.Append("INSERT INTO "+table+" ("+columns+") VALUES ("+values+")");
           // MessageBox.Show(query.ToString());
            using (conn)
            {
                using (SqlCommand command = new SqlCommand(query.ToString(), conn))
                {
                    foreach (var data in datas)
                    {
                       
                        command.Parameters.AddWithValue("@" + data.Key, data.Value);
                    }

                    try
                    {
                        conn.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("data saved");
                    }
                    catch (SqlException es)
                    {
                        MessageBox.Show(es.Message);
                    }
                    finally
                    {
                        conn.Close();

                    }

                }
            }
        }

        public void DeleteId(int Id, string Table)
        {
            StringBuilder query = new StringBuilder();
            query.Append("DELETE FROM " + Table+" WHERE id=@id");
            using (conn)
            {
                using (SqlCommand command = new SqlCommand(query.ToString(), conn))
                {          
                    command.Parameters.AddWithValue("@id", Id);

                    try
                    {
                        conn.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("data deleted");
                    }
                    catch (SqlException es)
                    {
                        MessageBox.Show(es.Message);
                    }
                    finally
                    {
                        conn.Close();

                    }

                }
            }
        }
    }
}
