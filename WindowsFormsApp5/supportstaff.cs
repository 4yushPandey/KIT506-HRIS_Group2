using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class supportstaff : Form
    {
        public supportstaff()
        {
            InitializeComponent();
            dashboardUC1.BringToFront();
        }

        private void supportstaff_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Width;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            classesunit1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            staffclass1.BringToFront();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dashboardUC1.BringToFront();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            staffconsultations1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            consultationsclass1.BringToFront();
        }
    }
}
