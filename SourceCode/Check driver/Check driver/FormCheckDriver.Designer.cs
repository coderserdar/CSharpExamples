namespace Check_driver
{
    partial class FormCheckDriver
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
            this.button2 = new System.Windows.Forms.Button();
            this.af = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLink.ForeColor = System.Drawing.Color.Navy;
            this.lblLink.Location = new System.Drawing.Point(491, 490);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(139, 16);
            this.lblLink.TabIndex = 25;
            this.lblLink.Text = "www.vclexamples.com";
            this.lblLink.Click += new System.EventHandler(this.lblLink_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(483, 456);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 26);
            this.button2.TabIndex = 24;
            this.button2.Text = "Check drivers";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // af
            // 
            this.af.FormattingEnabled = true;
            this.af.Location = new System.Drawing.Point(4, 4);
            this.af.Name = "af";
            this.af.Size = new System.Drawing.Size(1201, 446);
            this.af.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 510);
            this.Controls.Add(this.af);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check Windows drivers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox af;
    }
}

