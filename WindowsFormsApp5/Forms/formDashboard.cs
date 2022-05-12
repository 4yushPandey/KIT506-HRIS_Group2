using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5.Forms
{
    public partial class formDashboard : Form
    {
        public formDashboard()
        {
            InitializeComponent();
            
                dashboardUC1.BringToFront();
                labelTitle.Text = "";
            }
        

        private void button6_Click(object sender, EventArgs e)
        {
            staffconsultations1.BringToFront();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            consultations1.BringToFront();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboardUC1.BringToFront();
            labelTitle.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            donersUC1.BringToFront();
            labelTitle.Text = "";
        }

        private void formDashboard_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Width;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void donersUC1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            staff1.BringToFront();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            unit1.BringToFront();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            staffclass1.BringToFront();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            consultationsclass1.BringToFront();

        }

        private void button8_Click(object sender, EventArgs e)
        {
           classesunit1.BringToFront();

        }
    }
}
