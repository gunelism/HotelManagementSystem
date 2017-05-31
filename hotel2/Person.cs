using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace hotel2
{
    class Person
    {
       
        public string Name;
        public string SurName;
        public string TableName;

        database db = new database();


        public Person(string name, string surname, string tbName)
        {
            Name = name;
            SurName = surname;
            TableName = tbName;
        }

        public int select()
        {

            string query = "SELECT COUNT(*) FROM " + TableName + " WHERE name = @name AND surname = @surname";
            using (db.conn)
            {
                using (SqlCommand command = new SqlCommand(query, db.conn))
                {
                    command.Parameters.AddWithValue("@name", Name);
                    command.Parameters.AddWithValue("@surname", SurName);

                    try
                    {
                        db.conn.Open();
                        Int32 row = (Int32)command.ExecuteScalar();
                        return row;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                        return 0;
                    }
                }
            }
        }
    }
    
}
