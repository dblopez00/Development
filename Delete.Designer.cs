namespace Development
{
    partial class Delete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delete));
            this.panel6 = new System.Windows.Forms.Panel();
            this.btndelete = new System.Windows.Forms.Button();
            this.txid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.UpPanel = new System.Windows.Forms.Panel();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel6.Location = new System.Drawing.Point(38, 199);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(160, 1);
            this.panel6.TabIndex = 10;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(91)))));
            this.btndelete.Location = new System.Drawing.Point(213, 247);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(139, 40);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // txid
            // 
            this.txid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(91)))));
            this.txid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txid.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txid.Location = new System.Drawing.Point(75, 176);
            this.txid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txid.MaxLength = 11;
            this.txid.Name = "txid";
            this.txid.Size = new System.Drawing.Size(75, 20);
            this.txid.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(91)))));
            this.label6.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(33, 167);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = "ID:";
            // 
            // UpPanel
            // 
            this.UpPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpPanel.Controls.Add(this.btncerrar);
            this.UpPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpPanel.Location = new System.Drawing.Point(0, 0);
            this.UpPanel.Name = "UpPanel";
            this.UpPanel.Size = new System.Drawing.Size(421, 37);
            this.UpPanel.TabIndex = 11;
            this.UpPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpPanel_MouseDown);
            // 
            // btncerrar
            // 
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(389, 6);
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
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(32, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 33);
            this.label1.TabIndex = 12;
            this.label1.Text = "Development Delete";
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(421, 339);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpPanel);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.txid);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Delete";
            this.Text = "Delete";
            this.UpPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.TextBox txid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel UpPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btncerrar;
    }
}