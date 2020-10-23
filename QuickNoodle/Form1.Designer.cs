using System.Windows.Forms;

namespace QuickNoodle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.convert = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.welcome = new System.Windows.Forms.Label();
            this.overwriteColors = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.import = new System.Windows.Forms.Button();
            this.overwriteCustomData = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-1, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 82);
            this.button1.TabIndex = 1;
            this.button1.Text = "Open Map";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // save
            // 
            this.save.Enabled = false;
            this.save.Location = new System.Drawing.Point(218, 83);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(217, 82);
            this.save.TabIndex = 2;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // convert
            // 
            this.convert.Enabled = false;
            this.convert.Location = new System.Drawing.Point(218, -1);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(217, 82);
            this.convert.TabIndex = 3;
            this.convert.Text = "Convert";
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::QuickNoodle.Properties.Resources.the_real_bckill;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(18, 30);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(216, 82);
            this.button4.TabIndex = 4;
            this.button4.Text = "sex";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Location = new System.Drawing.Point(3, 7);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(129, 13);
            this.welcome.TabIndex = 5;
            this.welcome.Text = "Welcome to QuickNoodle";
            this.welcome.Click += new System.EventHandler(this.label1_Click);
            // 
            // overwriteColors
            // 
            this.overwriteColors.AutoSize = true;
            this.overwriteColors.Checked = true;
            this.overwriteColors.CheckState = System.Windows.Forms.CheckState.Checked;
            this.overwriteColors.Location = new System.Drawing.Point(275, 3);
            this.overwriteColors.Name = "overwriteColors";
            this.overwriteColors.Size = new System.Drawing.Size(160, 17);
            this.overwriteColors.TabIndex = 6;
            this.overwriteColors.Text = "Overwrite Old Custom Colors";
            this.overwriteColors.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.overwriteCustomData);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.overwriteColors);
            this.panel1.Controls.Add(this.welcome);
            this.panel1.Location = new System.Drawing.Point(-1, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 148);
            this.panel1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(321, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Show Log";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 51);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "Help";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // import
            // 
            this.import.Enabled = false;
            this.import.Location = new System.Drawing.Point(-1, 83);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(217, 82);
            this.import.TabIndex = 8;
            this.import.Text = "Import QuickNoodle File";
            this.import.UseVisualStyleBackColor = true;
            this.import.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // overwriteCustomData
            // 
            this.overwriteCustomData.AutoSize = true;
            this.overwriteCustomData.Location = new System.Drawing.Point(275, 26);
            this.overwriteCustomData.Name = "overwriteCustomData";
            this.overwriteCustomData.Size = new System.Drawing.Size(135, 17);
            this.overwriteCustomData.TabIndex = 9;
            this.overwriteCustomData.Text = "Overwrite Custom Data";
            this.overwriteCustomData.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1617, 852);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(418, 167);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(410, 141);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(410, 141);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 256);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.import);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.save);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "QuickNoodle";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.CheckBox overwriteColors;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button import;
        private System.Windows.Forms.Button button6;
        public System.Windows.Forms.Button button2;
        private CheckBox overwriteCustomData;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}

