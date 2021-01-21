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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.convert = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.welcome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.expand = new System.Windows.Forms.Button();
            this.multithreading = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.import = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.alternatingFraction = new System.Windows.Forms.TextBox();
            this.FractionToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.scrub = new System.Windows.Forms.CheckBox();
            this.argEditorButton = new System.Windows.Forms.Button();
            this.elapsed = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 1);
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
            this.save.Location = new System.Drawing.Point(221, 1);
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
            this.convert.Location = new System.Drawing.Point(221, 84);
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.elapsed);
            this.panel1.Controls.Add(this.expand);
            this.panel1.Controls.Add(this.multithreading);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.welcome);
            this.panel1.Location = new System.Drawing.Point(-1, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 148);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // expand
            // 
            this.expand.Location = new System.Drawing.Point(415, 9);
            this.expand.Name = "expand";
            this.expand.Size = new System.Drawing.Size(26, 23);
            this.expand.TabIndex = 11;
            this.expand.Text = "->";
            this.expand.UseVisualStyleBackColor = true;
            this.expand.Click += new System.EventHandler(this.button5_Click_2);
            // 
            // multithreading
            // 
            this.multithreading.AutoSize = true;
            this.multithreading.Location = new System.Drawing.Point(128, 100);
            this.multithreading.Name = "multithreading";
            this.multithreading.Size = new System.Drawing.Size(128, 17);
            this.multithreading.TabIndex = 10;
            this.multithreading.Text = "Enable Multithreading";
            this.multithreading.UseVisualStyleBackColor = true;
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(612, 226);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Open Preset Editor";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // import
            // 
            this.import.Enabled = false;
            this.import.Location = new System.Drawing.Point(2, 84);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(217, 82);
            this.import.TabIndex = 8;
            this.import.Text = "Import QuickNoodle File";
            this.import.UseVisualStyleBackColor = true;
            this.import.Click += new System.EventHandler(this.button5_Click_1);
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
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.import);
            this.panel2.Controls.Add(this.save);
            this.panel2.Controls.Add(this.convert);
            this.panel2.Location = new System.Drawing.Point(3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(442, 164);
            this.panel2.TabIndex = 11;
            // 
            // alternatingFraction
            // 
            this.alternatingFraction.Location = new System.Drawing.Point(700, 12);
            this.alternatingFraction.Name = "alternatingFraction";
            this.alternatingFraction.Size = new System.Drawing.Size(40, 20);
            this.alternatingFraction.TabIndex = 12;
            this.alternatingFraction.Text = "0.1875";
            this.FractionToolTip.SetToolTip(this.alternatingFraction, "The Fraction for how long ago (in beats)\r\n the previous ring spin event has to be" +
        " \r\nto alternate direction\r\n(if you don\'t know what this means, leave this alone." +
        ")");
            // 
            // FractionToolTip
            // 
            this.FractionToolTip.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // scrub
            // 
            this.scrub.AutoSize = true;
            this.scrub.Checked = true;
            this.scrub.CheckState = System.Windows.Forms.CheckState.Checked;
            this.scrub.Enabled = false;
            this.scrub.Location = new System.Drawing.Point(452, 12);
            this.scrub.Name = "scrub";
            this.scrub.Size = new System.Drawing.Size(132, 17);
            this.scrub.TabIndex = 13;
            this.scrub.Text = "Scrub old custom data";
            this.scrub.UseVisualStyleBackColor = true;
            // 
            // argEditorButton
            // 
            this.argEditorButton.Location = new System.Drawing.Point(467, 226);
            this.argEditorButton.Name = "argEditorButton";
            this.argEditorButton.Size = new System.Drawing.Size(127, 22);
            this.argEditorButton.TabIndex = 14;
            this.argEditorButton.Text = "Open Argument Editor";
            this.argEditorButton.UseVisualStyleBackColor = true;
            this.argEditorButton.Click += new System.EventHandler(this.argEditorButton_Click);
            // 
            // elapsed
            // 
            this.elapsed.AutoSize = true;
            this.elapsed.Location = new System.Drawing.Point(105, 56);
            this.elapsed.Name = "elapsed";
            this.elapsed.Size = new System.Drawing.Size(0, 13);
            this.elapsed.TabIndex = 12;
            this.elapsed.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 261);
            this.Controls.Add(this.argEditorButton);
            this.Controls.Add(this.scrub);
            this.Controls.Add(this.alternatingFraction);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "QuickNoodle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button import;
        private System.Windows.Forms.Button button6;
        public System.Windows.Forms.Button button2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private CheckBox multithreading;
        private Button button3;
        private Panel panel2;
        private TextBox alternatingFraction;
        private ToolTip FractionToolTip;
        private Button expand;
        private CheckBox scrub;
        private Button argEditorButton;
        private Label elapsed;
    }
}

