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
    public partial class DonersUC : UserControl
    {
        public DonersUC()
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
                    String query = "select * from class  ";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = reader["code"];
                        dataGridView1.Rows[n].Cells[1].Value = reader["campus"];
                        dataGridView1.Rows[n].Cells[2].Value = reader["day"];
                        dataGridView1.Rows[n].Cells[2].Value = reader["start"];
                        dataGridView1.Rows[n].Cells[2].Value = reader["end"];
                        dataGridView1.Rows[n].Cells[2].Value = reader["type"];
                        dataGridView1.Rows[n].Cells[2].Value = reader["room"];
                        dataGridView1.Rows[n].Cells[2].Value = reader["staff"];

                        Console.WriteLine(reader["code"]);
                        Console.WriteLine(reader["campus"]);
                        Console.WriteLine(reader["day"]);
                        Console.WriteLine(reader["start"]);
                        Console.WriteLine(reader["end"]);
                        Console.WriteLine(reader["tyoe"]);
                        Console.WriteLine(reader["room"]);
                        Console.WriteLine(reader["staff"]);
                    }


                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void DonersUC_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
