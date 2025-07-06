namespace WinFormsApp2.Forms
{
    partial class StudentForm
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
            label1 = new Label();
            label2 = new Label();
            txtid = new TextBox();
            txtname = new TextBox();
            dgvstudentdetails = new DataGridView();
            btnadd = new Button();
            label3 = new Label();
            txtage = new TextBox();
            city = new Label();
            txtcity = new TextBox();
            btnedit = new Button();
            btncl = new Button();
            btndelete = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvstudentdetails).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(51, 49);
            label1.Name = "label1";
            label1.Size = new Size(27, 21);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(51, 96);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // txtid
            // 
            txtid.Location = new Point(126, 49);
            txtid.Name = "txtid";
            txtid.Size = new Size(121, 23);
            txtid.TabIndex = 2;
            txtid.TextChanged += textBox1_TextChanged;
            // 
            // txtname
            // 
            txtname.Location = new Point(126, 96);
            txtname.Name = "txtname";
            txtname.Size = new Size(121, 23);
            txtname.TabIndex = 2;
            txtname.TextChanged += textBox1_TextChanged;
            // 
            // dgvstudentdetails
            // 
            dgvstudentdetails.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvstudentdetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvstudentdetails.Location = new Point(287, 49);
            dgvstudentdetails.Name = "dgvstudentdetails";
            dgvstudentdetails.Size = new Size(406, 288);
            dgvstudentdetails.TabIndex = 3;
            dgvstudentdetails.CellClick += dgvstudentdetails_CellClick;
            // 
            // btnadd
            // 
            btnadd.BackColor = SystemColors.GradientActiveCaption;
            btnadd.FlatStyle = FlatStyle.Flat;
            btnadd.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnadd.Location = new Point(23, 238);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(87, 37);
            btnadd.TabIndex = 4;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = false;
            btnadd.Click += btnadd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(51, 138);
            label3.Name = "label3";
            label3.Size = new Size(40, 21);
            label3.TabIndex = 1;
            label3.Text = "Age";
            // 
            // txtage
            // 
            txtage.Location = new Point(126, 138);
            txtage.Name = "txtage";
            txtage.Size = new Size(121, 23);
            txtage.TabIndex = 2;
            txtage.TextChanged += textBox1_TextChanged;
            // 
            // city
            // 
            city.AutoSize = true;
            city.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            city.Location = new Point(51, 180);
            city.Name = "city";
            city.Size = new Size(40, 21);
            city.TabIndex = 1;
            city.Text = "City";
            // 
            // txtcity
            // 
            txtcity.Location = new Point(126, 180);
            txtcity.Name = "txtcity";
            txtcity.Size = new Size(121, 23);
            txtcity.TabIndex = 2;
            txtcity.TextChanged += textBox1_TextChanged;
            // 
            // btnedit
            // 
            btnedit.BackColor = SystemColors.GradientActiveCaption;
            btnedit.FlatStyle = FlatStyle.Flat;
            btnedit.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnedit.Location = new Point(171, 238);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(87, 37);
            btnedit.TabIndex = 4;
            btnedit.Text = "Edit";
            btnedit.UseVisualStyleBackColor = false;
            btnedit.Click += btnedit_Click;
            // 
            // btncl
            // 
            btncl.BackColor = SystemColors.GradientActiveCaption;
            btncl.FlatStyle = FlatStyle.Flat;
            btncl.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btncl.Location = new Point(171, 300);
            btncl.Name = "btncl";
            btncl.Size = new Size(87, 37);
            btncl.TabIndex = 4;
            btncl.Text = "Clear";
            btncl.UseVisualStyleBackColor = false;
            btncl.Click += btncl_Click;
            // 
            // btndelete
            // 
            btndelete.BackColor = SystemColors.GradientActiveCaption;
            btndelete.FlatStyle = FlatStyle.Flat;
            btndelete.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btndelete.Location = new Point(23, 300);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(87, 37);
            btndelete.TabIndex = 4;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(254, 9);
            label4.Name = "label4";
            label4.Size = new Size(206, 25);
            label4.TabIndex = 0;
            label4.Text = "Student Management";
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 363);
            Controls.Add(btndelete);
            Controls.Add(btncl);
            Controls.Add(btnedit);
            Controls.Add(btnadd);
            Controls.Add(dgvstudentdetails);
            Controls.Add(txtcity);
            Controls.Add(txtage);
            Controls.Add(city);
            Controls.Add(txtname);
            Controls.Add(label3);
            Controls.Add(txtid);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "StudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentForm";
            Load += StudentForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvstudentdetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtid;
        private TextBox txtname;
        private DataGridView dgvstudentdetails;
        private Button btnadd;
        private Label label3;
        private TextBox txtage;
        private Label city;
        private TextBox txtcity;
        private Button btnedit;
        private Button btncl;
        private Button btndelete;
        private Label label4;
    }
}