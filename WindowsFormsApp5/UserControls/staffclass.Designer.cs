
namespace WindowsFormsApp5.UserControls
{
    partial class staffclass
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.unit_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(393, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "View class for staff";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.unit_code,
            this.campus,
            this.day,
            this.start,
            this.end,
            this.type,
            this.room,
            this.staff});
            this.dataGridView1.Location = new System.Drawing.Point(43, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1401, 497);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // unit_code
            // 
            this.unit_code.HeaderText = "unit_code";
            this.unit_code.MinimumWidth = 10;
            this.unit_code.Name = "unit_code";
            this.unit_code.Width = 200;
            // 
            // campus
            // 
            this.campus.HeaderText = "campus";
            this.campus.MinimumWidth = 10;
            this.campus.Name = "campus";
            this.campus.Width = 200;
            // 
            // day
            // 
            this.day.HeaderText = "day";
            this.day.MinimumWidth = 10;
            this.day.Name = "day";
            this.day.Width = 200;
            // 
            // start
            // 
            this.start.HeaderText = "start";
            this.start.MinimumWidth = 10;
            this.start.Name = "start";
            this.start.Width = 200;
            // 
            // end
            // 
            this.end.HeaderText = "end";
            this.end.MinimumWidth = 10;
            this.end.Name = "end";
            this.end.Width = 200;
            // 
            // type
            // 
            this.type.HeaderText = "type";
            this.type.MinimumWidth = 10;
            this.type.Name = "type";
            this.type.Width = 200;
            // 
            // room
            // 
            this.room.HeaderText = "room";
            this.room.MinimumWidth = 10;
            this.room.Name = "room";
            this.room.Width = 200;
            // 
            // staff
            // 
            this.staff.HeaderText = "staff";
            this.staff.MinimumWidth = 10;
            this.staff.Name = "staff";
            this.staff.Width = 200;
            // 
            // staffclass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "staffclass";
            this.Size = new System.Drawing.Size(1520, 1145);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn campus;
        private System.Windows.Forms.DataGridViewTextBoxColumn day;
        private System.Windows.Forms.DataGridViewTextBoxColumn start;
        private System.Windows.Forms.DataGridViewTextBoxColumn end;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn room;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff;
    }
}
