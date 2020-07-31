namespace crudinmongodb
{
    partial class crudstudent
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1id = new System.Windows.Forms.TextBox();
            this.textBox2name = new System.Windows.Forms.TextBox();
            this.textBox3rollno = new System.Windows.Forms.TextBox();
            this.textBox4totalmark = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5gpa = new System.Windows.Forms.TextBox();
            this.button1insert = new System.Windows.Forms.Button();
            this.button2update = new System.Windows.Forms.Button();
            this.button3delete = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(478, 211);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(544, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(544, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(544, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "rollno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(544, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "totalmark";
            // 
            // textBox1id
            // 
            this.textBox1id.Location = new System.Drawing.Point(621, 24);
            this.textBox1id.Name = "textBox1id";
            this.textBox1id.ReadOnly = true;
            this.textBox1id.Size = new System.Drawing.Size(100, 20);
            this.textBox1id.TabIndex = 5;
            this.textBox1id.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2name
            // 
            this.textBox2name.Location = new System.Drawing.Point(621, 62);
            this.textBox2name.Name = "textBox2name";
            this.textBox2name.Size = new System.Drawing.Size(100, 20);
            this.textBox2name.TabIndex = 6;
            // 
            // textBox3rollno
            // 
            this.textBox3rollno.Location = new System.Drawing.Point(621, 110);
            this.textBox3rollno.Name = "textBox3rollno";
            this.textBox3rollno.Size = new System.Drawing.Size(100, 20);
            this.textBox3rollno.TabIndex = 7;
            // 
            // textBox4totalmark
            // 
            this.textBox4totalmark.Location = new System.Drawing.Point(621, 156);
            this.textBox4totalmark.Name = "textBox4totalmark";
            this.textBox4totalmark.Size = new System.Drawing.Size(100, 20);
            this.textBox4totalmark.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(544, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "gpa";
            // 
            // textBox5gpa
            // 
            this.textBox5gpa.Location = new System.Drawing.Point(621, 202);
            this.textBox5gpa.Name = "textBox5gpa";
            this.textBox5gpa.Size = new System.Drawing.Size(100, 20);
            this.textBox5gpa.TabIndex = 10;
            // 
            // button1insert
            // 
            this.button1insert.Location = new System.Drawing.Point(26, 259);
            this.button1insert.Name = "button1insert";
            this.button1insert.Size = new System.Drawing.Size(75, 23);
            this.button1insert.TabIndex = 11;
            this.button1insert.Text = "insert";
            this.button1insert.UseVisualStyleBackColor = true;
            this.button1insert.Click += new System.EventHandler(this.button1insert_Click);
            // 
            // button2update
            // 
            this.button2update.Location = new System.Drawing.Point(125, 259);
            this.button2update.Name = "button2update";
            this.button2update.Size = new System.Drawing.Size(75, 23);
            this.button2update.TabIndex = 12;
            this.button2update.Text = "update";
            this.button2update.UseVisualStyleBackColor = true;
            this.button2update.Click += new System.EventHandler(this.button2update_Click);
            // 
            // button3delete
            // 
            this.button3delete.Location = new System.Drawing.Point(221, 259);
            this.button3delete.Name = "button3delete";
            this.button3delete.Size = new System.Drawing.Size(75, 23);
            this.button3delete.TabIndex = 13;
            this.button3delete.Text = "delete";
            this.button3delete.UseVisualStyleBackColor = true;
            this.button3delete.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(330, 259);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "rdlc reports";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(429, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "crystal report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // crudstudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 296);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3delete);
            this.Controls.Add(this.button2update);
            this.Controls.Add(this.button1insert);
            this.Controls.Add(this.textBox5gpa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4totalmark);
            this.Controls.Add(this.textBox3rollno);
            this.Controls.Add(this.textBox2name);
            this.Controls.Add(this.textBox1id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "crudstudent";
            this.Text = "student details";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1id;
        private System.Windows.Forms.TextBox textBox2name;
        private System.Windows.Forms.TextBox textBox3rollno;
        private System.Windows.Forms.TextBox textBox4totalmark;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5gpa;
        private System.Windows.Forms.Button button1insert;
        private System.Windows.Forms.Button button2update;
        private System.Windows.Forms.Button button3delete;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
    }
}

