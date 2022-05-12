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
    public partial class consultations : UserControl
    {
        public consultations()
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
                    String query = "select * from consultation";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = reader["staff_id"];
                        dataGridView1.Rows[n].Cells[1].Value = reader["day"];
                        dataGridView1.Rows[n].Cells[2].Value = reader["start"];
                        dataGridView1.Rows[n].Cells[3].Value = reader["end"];
                        Console.WriteLine(reader["staff_id"]);
                        Console.WriteLine(reader["day"]);
                        Console.WriteLine(reader["start"]);
                        Console.WriteLine(reader["end"]);

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
