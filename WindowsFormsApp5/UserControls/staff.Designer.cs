
namespace WindowsFormsApp5.UserControls
{
    partial class staff
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
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.given_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.family_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(174, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "View all the staff";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.given_name,
            this.family_name,
            this.title,
            this.campus,
            this.email,
            this.photo,
            this.category});
            this.dataGridView1.Location = new System.Drawing.Point(3, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1045, 565);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // given_name
            // 
            this.given_name.HeaderText = "given_name";
            this.given_name.MinimumWidth = 6;
            this.given_name.Name = "given_name";
            this.given_name.Width = 125;
            // 
            // family_name
            // 
            this.family_name.HeaderText = "family_name";
            this.family_name.MinimumWidth = 6;
            this.family_name.Name = "family_name";
            this.family_name.Width = 125;
            // 
            // title
            // 
            this.title.HeaderText = "title";
            this.title.MinimumWidth = 6;
            this.title.Name = "title";
            this.title.Width = 125;
            // 
            // campus
            // 
            this.campus.HeaderText = "campus";
            this.campus.MinimumWidth = 6;
            this.campus.Name = "campus";
            this.campus.Width = 125;
            // 
            // email
            // 
            this.email.HeaderText = "email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Width = 125;
            // 
            // photo
            // 
            this.photo.HeaderText = "photo";
            this.photo.MinimumWidth = 6;
            this.photo.Name = "photo";
            this.photo.Width = 125;
            // 
            // category
            // 
            this.category.HeaderText = "category";
            this.category.MinimumWidth = 6;
            this.category.Name = "category";
            this.category.Width = 125;
            // 
            // staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "staff";
            this.Size = new System.Drawing.Size(1051, 714);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn given_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn family_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn campus;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn photo;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
    }
}
