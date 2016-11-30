namespace RPGFramework.GUI
{
    partial class Disclaimer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Disclaimer));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Dsc_Ok = new System.Windows.Forms.Button();
            this.Dsc_Ok_Fu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(260, 139);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // Dsc_Ok
            // 
            this.Dsc_Ok.Location = new System.Drawing.Point(13, 226);
            this.Dsc_Ok.Name = "Dsc_Ok";
            this.Dsc_Ok.Size = new System.Drawing.Size(75, 23);
            this.Dsc_Ok.TabIndex = 2;
            this.Dsc_Ok.Text = "OK";
            this.Dsc_Ok.UseVisualStyleBackColor = true;
            this.Dsc_Ok.Click += new System.EventHandler(this.Dsc_Ok_Click);
            // 
            // Dsc_Ok_Fu
            // 
            this.Dsc_Ok_Fu.Location = new System.Drawing.Point(140, 210);
            this.Dsc_Ok_Fu.Name = "Dsc_Ok_Fu";
            this.Dsc_Ok_Fu.Size = new System.Drawing.Size(131, 39);
            this.Dsc_Ok_Fu.TabIndex = 3;
            this.Dsc_Ok_Fu.Text = "You suck but I have no choice but to agree";
            this.Dsc_Ok_Fu.UseVisualStyleBackColor = true;
            this.Dsc_Ok_Fu.Click += new System.EventHandler(this.Dsc_Ok_Fu_Click);
            // 
            // Disclaimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Dsc_Ok_Fu);
            this.Controls.Add(this.Dsc_Ok);
            this.Controls.Add(this.textBox1);
            this.Name = "Disclaimer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Disclaimer";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Dsc_Ok;
        private System.Windows.Forms.Button Dsc_Ok_Fu;
    }
}