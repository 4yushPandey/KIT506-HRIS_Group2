
namespace WindowsFormsApp5
{
    partial class supportstaff
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dashboardUC1 = new WindowsFormsApp5.UserControls.DashboardUC();
            this.staffclass1 = new WindowsFormsApp5.UserControls.staffclass();
            this.staffconsultations1 = new WindowsFormsApp5.UserControls.staffconsultations();
            this.consultationsclass1 = new WindowsFormsApp5.UserControls.consultationsclass();
            this.classesunit1 = new WindowsFormsApp5.UserControls.classesunit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 743);
            this.panel1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button4.Location = new System.Drawing.Point(19, 604);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(251, 113);
            this.button4.TabIndex = 3;
            this.button4.Text = "view classes for unit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button3.Location = new System.Drawing.Point(19, 432);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(259, 127);
            this.button3.TabIndex = 2;
            this.button3.Text = "view consultations for class";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button2.Location = new System.Drawing.Point(28, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(259, 110);
            this.button2.TabIndex = 1;
            this.button2.Text = "view consultations for staff";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(19, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 103);
            this.button1.TabIndex = 0;
            this.button1.Text = "View classes for staff";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button5.Location = new System.Drawing.Point(19, 44);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(251, 70);
            this.button5.TabIndex = 4;
            this.button5.Text = "Dashboard";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dashboardUC1
            // 
            this.dashboardUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dashboardUC1.Location = new System.Drawing.Point(358, 13);
            this.dashboardUC1.Margin = new System.Windows.Forms.Padding(4);
            this.dashboardUC1.Name = "dashboardUC1";
            this.dashboardUC1.Size = new System.Drawing.Size(919, 739);
            this.dashboardUC1.TabIndex = 1;
            // 
            // staffclass1
            // 
            this.staffclass1.Location = new System.Drawing.Point(347, 2);
            this.staffclass1.Name = "staffclass1";
            this.staffclass1.Size = new System.Drawing.Size(1013, 750);
            this.staffclass1.TabIndex = 2;
            // 
            // staffconsultations1
            // 
            this.staffconsultations1.Location = new System.Drawing.Point(347, 2);
            this.staffconsultations1.Name = "staffconsultations1";
            this.staffconsultations1.Size = new System.Drawing.Size(921, 753);
            this.staffconsultations1.TabIndex = 3;
            // 
            // consultationsclass1
            // 
            this.consultationsclass1.Location = new System.Drawing.Point(346, -1);
            this.consultationsclass1.Name = "consultationsclass1";
            this.consultationsclass1.Size = new System.Drawing.Size(931, 756);
            this.consultationsclass1.TabIndex = 4;
            // 
            // classesunit1
            // 
            this.classesunit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.classesunit1.Location = new System.Drawing.Point(346, -1);
            this.classesunit1.Margin = new System.Windows.Forms.Padding(0);
            this.classesunit1.Name = "classesunit1";
            this.classesunit1.Size = new System.Drawing.Size(931, 776);
            this.classesunit1.TabIndex = 5;
            // 
            // supportstaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 754);
            this.Controls.Add(this.classesunit1);
            this.Controls.Add(this.consultationsclass1);
            this.Controls.Add(this.staffconsultations1);
            this.Controls.Add(this.staffclass1);
            this.Controls.Add(this.dashboardUC1);
            this.Controls.Add(this.panel1);
            this.Name = "supportstaff";
            this.Text = "supportstaff";
            this.Load += new System.EventHandler(this.supportstaff_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private UserControls.DashboardUC dashboardUC1;
        private UserControls.staffclass staffclass1;
        private UserControls.staffconsultations staffconsultations1;
        private UserControls.consultationsclass consultationsclass1;
        private UserControls.classesunit classesunit1;
    }
}