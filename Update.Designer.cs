namespace Development
{
    partial class Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update));
            this.UpPanel = new System.Windows.Forms.Panel();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txwhere = new System.Windows.Forms.TextBox();
            this.txset = new System.Windows.Forms.TextBox();
            this.txcamp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.UpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // UpPanel
            // 
            this.UpPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpPanel.Controls.Add(this.btncerrar);
            this.UpPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpPanel.Location = new System.Drawing.Point(0, 0);
            this.UpPanel.Name = "UpPanel";
            this.UpPanel.Size = new System.Drawing.Size(428, 46);
            this.UpPanel.TabIndex = 0;
            this.UpPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpPanel_MouseDown);
            // 
            // btncerrar
            // 
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(397, 8);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(23, 24);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btncerrar.TabIndex = 5;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(91)))));
            this.btnupdate.Location = new System.Drawing.Point(212, 321);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(172, 43);
            this.btnupdate.TabIndex = 4;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txwhere
            // 
            this.txwhere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(91)))));
            this.txwhere.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txwhere.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txwhere.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txwhere.Location = new System.Drawing.Point(108, 258);
            this.txwhere.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txwhere.Name = "txwhere";
            this.txwhere.Size = new System.Drawing.Size(276, 23);
            this.txwhere.TabIndex = 3;
            // 
            // txset
            // 
            this.txset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(91)))));
            this.txset.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txset.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txset.Location = new System.Drawing.Point(75, 206);
            this.txset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txset.Name = "txset";
            this.txset.Size = new System.Drawing.Size(240, 23);
            this.txset.TabIndex = 2;
            // 
            // txcamp
            // 
            this.txcamp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(91)))));
            this.txcamp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txcamp.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txcamp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txcamp.Location = new System.Drawing.Point(105, 151);
            this.txcamp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txcamp.Name = "txcamp";
            this.txcamp.Size = new System.Drawing.Size(253, 23);
            this.txcamp.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(91)))));
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(28, 256);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Where:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(91)))));
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(28, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Set:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(91)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(28, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Camp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(86, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Development Update";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(33, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 1);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Location = new System.Drawing.Point(33, 284);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(351, 1);
            this.panel3.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Location = new System.Drawing.Point(33, 232);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(282, 1);
            this.panel4.TabIndex = 13;
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(428, 420);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.txwhere);
            this.Controls.Add(this.txset);
            this.Controls.Add(this.txcamp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Update";
            this.Text = "Update";
            this.UpPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel UpPanel;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txwhere;
        private System.Windows.Forms.TextBox txset;
        private System.Windows.Forms.TextBox txcamp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}