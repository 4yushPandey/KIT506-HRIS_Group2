using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5.UserControls
{
    public partial class staff : UserControl
    {
        public staff()
        {
            InitializeComponent();
            try
            {
                String Server = "alacritas.cis.utas.edu.au";
                String Databse = "hris";
                String Password = "hris";
                String username = "hris";
                String Constring = "SERVER=" + Server + ";" + "DATABASE=" + Databse + ";" +
                       "UID=" + username + ";" + "PASSWORD=" + Password + ";";

                MySqlConnection connection = new MySqlConnection(Constring);
                Console.WriteLine("a");
                connection.Open();
                Console.WriteLine("b");
                if (connection.State == ConnectionState.Open)
                {
                    String query = "select * from staff";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = reader["id"];
                        dataGridView1.Rows[n].Cells[1].Value = reader["given_name"];
                        dataGridView1.Rows[n].Cells[2].Value = reader["family_name"];
                        dataGridView1.Rows[n].Cells[3].Value = reader["title"];
                        dataGridView1.Rows[n].Cells[4].Value = reader["campus"];
                        dataGridView1.Rows[n].Cells[5].Value = reader["phone"];
                        dataGridView1.Rows[n].Cells[6].Value = reader["room"];
                        dataGridView1.Rows[n].Cells[7].Value = reader["email"];
                        dataGridView1.Rows[n].Cells[8].Value = reader["photo"];
                        dataGridView1.Rows[n].Cells[9].Value = reader["category"];

                        Console.WriteLine(reader["id"]);
                        Console.WriteLine(reader["given_name"]);
                        Console.WriteLine(reader["family_name"]);
                        Console.WriteLine(reader["title"]);
                        Console.WriteLine(reader["campus"]);
                        Console.WriteLine(reader["phone"]);
                        Console.WriteLine(reader["room"]);
                        Console.WriteLine(reader["email"]);
                        Console.WriteLine(reader["photo"]);
                        Console.WriteLine(reader["category"]);


                    }


                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
