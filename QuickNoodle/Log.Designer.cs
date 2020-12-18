namespace QuickNoodle
{
    partial class Log
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
            this.logbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // logbox
            // 
            this.logbox.BackColor = System.Drawing.SystemColors.Control;
            this.logbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logbox.Location = new System.Drawing.Point(10, 12);
            this.logbox.Multiline = true;
            this.logbox.Name = "logbox";
            this.logbox.ReadOnly = true;
            this.logbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logbox.Size = new System.Drawing.Size(279, 950);
            this.logbox.TabIndex = 0;
            this.logbox.TextChanged += new System.EventHandler(this.logbox_TextChanged);
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 461);
            this.Controls.Add(this.logbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(319, 1000);
            this.Name = "Log";
            this.Text = "Log";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox logbox;
    }
}