namespace EnumerateWindows
{
    partial class FormEnumerateWindows
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
            this.lblLink = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLink.ForeColor = System.Drawing.Color.Navy;
            this.lblLink.Location = new System.Drawing.Point(147, 9);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(139, 16);
            this.lblLink.TabIndex = 8;
            this.lblLink.Text = "www.vclexamples.com";
            this.lblLink.Click += new System.EventHandler(this.lblLink_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(4, 30);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(51, 13);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Windows";
            // 
            // ListBox1
            // 
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.Location = new System.Drawing.Point(5, 46);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(281, 160);
            this.ListBox1.TabIndex = 6;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(68, 212);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(169, 25);
            this.Button1.TabIndex = 5;
            this.Button1.Text = "Enumerate windows";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 246);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.ListBox1);
            this.Controls.Add(this.Button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enumerate windows example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLink;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ListBox ListBox1;
        internal System.Windows.Forms.Button Button1;
    }
}

