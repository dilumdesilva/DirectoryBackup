namespace DirectoryBackup_GUI_Application
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblPath1 = new System.Windows.Forms.Label();
            this.btnPath1 = new System.Windows.Forms.Button();
            this.btnPath2 = new System.Windows.Forms.Button();
            this.lblPath2 = new System.Windows.Forms.Label();
            this.btnPath3 = new System.Windows.Forms.Button();
            this.lblPath3 = new System.Windows.Forms.Label();
            this.btnPath4 = new System.Windows.Forms.Button();
            this.lblPath4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Backup Directories";
            // 
            // lblPath1
            // 
            this.lblPath1.AutoSize = true;
            this.lblPath1.Location = new System.Drawing.Point(55, 87);
            this.lblPath1.Name = "lblPath1";
            this.lblPath1.Size = new System.Drawing.Size(111, 13);
            this.lblPath1.TabIndex = 1;
            this.lblPath1.Text = "Path of the directory 1";
            this.lblPath1.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnPath1
            // 
            this.btnPath1.Location = new System.Drawing.Point(55, 115);
            this.btnPath1.Name = "btnPath1";
            this.btnPath1.Size = new System.Drawing.Size(75, 23);
            this.btnPath1.TabIndex = 6;
            this.btnPath1.Text = "Set Path";
            this.btnPath1.UseVisualStyleBackColor = true;
            this.btnPath1.Click += new System.EventHandler(this.btnPath1_Click);
            // 
            // btnPath2
            // 
            this.btnPath2.Location = new System.Drawing.Point(52, 184);
            this.btnPath2.Name = "btnPath2";
            this.btnPath2.Size = new System.Drawing.Size(75, 23);
            this.btnPath2.TabIndex = 8;
            this.btnPath2.Text = "Set Path";
            this.btnPath2.UseVisualStyleBackColor = true;
            this.btnPath2.Click += new System.EventHandler(this.btnPath2_Click);
            // 
            // lblPath2
            // 
            this.lblPath2.AutoSize = true;
            this.lblPath2.Location = new System.Drawing.Point(52, 156);
            this.lblPath2.Name = "lblPath2";
            this.lblPath2.Size = new System.Drawing.Size(111, 13);
            this.lblPath2.TabIndex = 7;
            this.lblPath2.Text = "Path of the directory 2";
            // 
            // btnPath3
            // 
            this.btnPath3.Location = new System.Drawing.Point(52, 256);
            this.btnPath3.Name = "btnPath3";
            this.btnPath3.Size = new System.Drawing.Size(75, 23);
            this.btnPath3.TabIndex = 10;
            this.btnPath3.Text = "Set Path";
            this.btnPath3.UseVisualStyleBackColor = true;
            this.btnPath3.Click += new System.EventHandler(this.btnPath3_Click);
            // 
            // lblPath3
            // 
            this.lblPath3.AutoSize = true;
            this.lblPath3.Location = new System.Drawing.Point(52, 228);
            this.lblPath3.Name = "lblPath3";
            this.lblPath3.Size = new System.Drawing.Size(111, 13);
            this.lblPath3.TabIndex = 9;
            this.lblPath3.Text = "Path of the directory 3";
            // 
            // btnPath4
            // 
            this.btnPath4.Location = new System.Drawing.Point(52, 329);
            this.btnPath4.Name = "btnPath4";
            this.btnPath4.Size = new System.Drawing.Size(75, 23);
            this.btnPath4.TabIndex = 12;
            this.btnPath4.Text = "Set Path";
            this.btnPath4.UseVisualStyleBackColor = true;
            this.btnPath4.Click += new System.EventHandler(this.btnPath4_Click);
            // 
            // lblPath4
            // 
            this.lblPath4.AutoSize = true;
            this.lblPath4.Location = new System.Drawing.Point(52, 301);
            this.lblPath4.Name = "lblPath4";
            this.lblPath4.Size = new System.Drawing.Size(111, 13);
            this.lblPath4.TabIndex = 11;
            this.lblPath4.Text = "Path of the directory 4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Back up all directories";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 427);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPath4);
            this.Controls.Add(this.lblPath4);
            this.Controls.Add(this.btnPath3);
            this.Controls.Add(this.lblPath3);
            this.Controls.Add(this.btnPath2);
            this.Controls.Add(this.lblPath2);
            this.Controls.Add(this.btnPath1);
            this.Controls.Add(this.lblPath1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPath1;
        private System.Windows.Forms.Button btnPath1;
        private System.Windows.Forms.Button btnPath2;
        private System.Windows.Forms.Label lblPath2;
        private System.Windows.Forms.Button btnPath3;
        private System.Windows.Forms.Label lblPath3;
        private System.Windows.Forms.Button btnPath4;
        private System.Windows.Forms.Label lblPath4;
        private System.Windows.Forms.Button button1;
    }
}

