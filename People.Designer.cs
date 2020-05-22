namespace Development
{
    partial class People
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(People));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txage = new System.Windows.Forms.TextBox();
            this.txphone = new System.Windows.Forms.TextBox();
            this.txced = new System.Windows.Forms.TextBox();
            this.txname = new System.Windows.Forms.TextBox();
            this.txlastname = new System.Windows.Forms.TextBox();
            this.txgender = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnregister = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            this.datashow = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datashow)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btnminimizar);
            this.panel1.Controls.Add(this.btncerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 42);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnminimizar
            // 
            this.btnminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnminimizar.Image")));
            this.btnminimizar.Location = new System.Drawing.Point(945, 7);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(23, 24);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnminimizar.TabIndex = 5;
            this.btnminimizar.TabStop = false;
            // 
            // btncerrar
            // 
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(983, 7);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(23, 24);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btncerrar.TabIndex = 6;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(91)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(41, 185);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(91)))));
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(41, 264);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lastname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(91)))));
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(41, 340);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(91)))));
            this.label4.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(666, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Age:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(91)))));
            this.label5.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(666, 264);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Phone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(91)))));
            this.label6.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(666, 340);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cedula:";
            // 
            // txage
            // 
            this.txage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(91)))));
            this.txage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txage.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txage.Location = new System.Drawing.Point(724, 194);
            this.txage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txage.Name = "txage";
            this.txage.Size = new System.Drawing.Size(150, 20);
            this.txage.TabIndex = 4;
            // 
            // txphone
            // 
            this.txphone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(91)))));
            this.txphone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txphone.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txphone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txphone.Location = new System.Drawing.Point(748, 270);
            this.txphone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txphone.MaxLength = 10;
            this.txphone.Name = "txphone";
            this.txphone.Size = new System.Drawing.Size(150, 20);
            this.txphone.TabIndex = 5;
            // 
            // txced
            // 
            this.txced.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(91)))));
            this.txced.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txced.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txced.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txced.Location = new System.Drawing.Point(756, 345);
            this.txced.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txced.MaxLength = 11;
            this.txced.Name = "txced";
            this.txced.Size = new System.Drawing.Size(219, 20);
            this.txced.TabIndex = 6;
            // 
            // txname
            // 
            this.txname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(91)))));
            this.txname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txname.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txname.Location = new System.Drawing.Point(121, 191);
            this.txname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txname.MaxLength = 200;
            this.txname.Name = "txname";
            this.txname.Size = new System.Drawing.Size(381, 20);
            this.txname.TabIndex = 1;
            // 
            // txlastname
            // 
            this.txlastname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(91)))));
            this.txlastname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txlastname.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txlastname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txlastname.Location = new System.Drawing.Point(162, 271);
            this.txlastname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txlastname.MaxLength = 200;
            this.txlastname.Name = "txlastname";
            this.txlastname.Size = new System.Drawing.Size(333, 20);
            this.txlastname.TabIndex = 2;
            // 
            // txgender
            // 
            this.txgender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(91)))));
            this.txgender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txgender.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txgender.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txgender.Location = new System.Drawing.Point(138, 346);
            this.txgender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txgender.MaxLength = 15;
            this.txgender.Name = "txgender";
            this.txgender.Size = new System.Drawing.Size(210, 20);
            this.txgender.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(295, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(375, 45);
            this.label7.TabIndex = 3;
            this.label7.Text = "Development Register";
            // 
            // btnregister
            // 
            this.btnregister.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(91)))));
            this.btnregister.Location = new System.Drawing.Point(152, 452);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(139, 43);
            this.btnregister.TabIndex = 7;
            this.btnregister.Text = "Register";
            this.btnregister.UseVisualStyleBackColor = false;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(91)))));
            this.btnupdate.Location = new System.Drawing.Point(352, 452);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(139, 43);
            this.btnupdate.TabIndex = 8;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(91)))));
            this.btndelete.Location = new System.Drawing.Point(541, 452);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(139, 43);
            this.btndelete.TabIndex = 9;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnshow
            // 
            this.btnshow.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnshow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnshow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(91)))));
            this.btnshow.Location = new System.Drawing.Point(725, 452);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(139, 43);
            this.btnshow.TabIndex = 10;
            this.btnshow.Text = "Show";
            this.btnshow.UseVisualStyleBackColor = false;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // datashow
            // 
            this.datashow.BackgroundColor = System.Drawing.SystemColors.Control;
            this.datashow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.datashow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datashow.Location = new System.Drawing.Point(152, 528);
            this.datashow.Name = "datashow";
            this.datashow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.datashow.Size = new System.Drawing.Size(712, 169);
            this.datashow.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(46, 214);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 1);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Location = new System.Drawing.Point(46, 294);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(456, 1);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Location = new System.Drawing.Point(46, 369);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(302, 1);
            this.panel4.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel5.Location = new System.Drawing.Point(671, 217);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(203, 1);
            this.panel5.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel6.Location = new System.Drawing.Point(671, 368);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(304, 1);
            this.panel6.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel7.Location = new System.Drawing.Point(671, 293);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(227, 1);
            this.panel7.TabIndex = 6;
            // 
            // People
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1014, 709);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.datashow);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txgender);
            this.Controls.Add(this.txced);
            this.Controls.Add(this.txlastname);
            this.Controls.Add(this.txphone);
            this.Controls.Add(this.txname);
            this.Controls.Add(this.txage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "People";
            this.Text = "People";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datashow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txage;
        private System.Windows.Forms.TextBox txphone;
        private System.Windows.Forms.TextBox txced;
        private System.Windows.Forms.TextBox txname;
        private System.Windows.Forms.TextBox txlastname;
        private System.Windows.Forms.TextBox txgender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.DataGridView datashow;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.PictureBox btncerrar;
    }
}