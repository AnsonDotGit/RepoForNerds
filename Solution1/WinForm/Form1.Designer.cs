namespace WinForm
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
            this.MB1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // MB1
            // 
            this.MB1.Location = new System.Drawing.Point(23, 63);
            this.MB1.Name = "MB1";
            this.MB1.Size = new System.Drawing.Size(317, 296);
            this.MB1.TabIndex = 0;
            this.MB1.Text = "MB";
            this.MB1.UseSelectable = true;
            this.MB1.Click += new System.EventHandler(this.MB1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 382);
            this.Controls.Add(this.MB1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton MB1;
    }
}

