namespace QuickNoodle
{
    partial class ArguimentEditor
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
            this.name1 = new System.Windows.Forms.TextBox();
            this.nameText1 = new System.Windows.Forms.Label();
            this.namePanel1 = new System.Windows.Forms.Panel();
            this.ObjectType1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.eventValue1 = new System.Windows.Forms.TextBox();
            this.eventType1 = new System.Windows.Forms.TextBox();
            this.EventValueLabel1 = new System.Windows.Forms.Label();
            this.eventTypeLabel1 = new System.Windows.Forms.Label();
            this.DataType1 = new System.Windows.Forms.ComboBox();
            this.DataTypeLabel1 = new System.Windows.Forms.Label();
            this.DataNameLabel1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.namePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // name1
            // 
            this.name1.Location = new System.Drawing.Point(6, 20);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(100, 20);
            this.name1.TabIndex = 0;
            this.name1.Text = "njs";
            this.name1.TextChanged += new System.EventHandler(this.nameBox1_TextChanged);
            // 
            // nameText1
            // 
            this.nameText1.AutoSize = true;
            this.nameText1.Location = new System.Drawing.Point(3, 4);
            this.nameText1.Name = "nameText1";
            this.nameText1.Size = new System.Drawing.Size(35, 13);
            this.nameText1.TabIndex = 1;
            this.nameText1.Text = "Name";
            // 
            // namePanel1
            // 
            this.namePanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.namePanel1.Controls.Add(this.DataTypeLabel1);
            this.namePanel1.Controls.Add(this.DataType1);
            this.namePanel1.Controls.Add(this.eventTypeLabel1);
            this.namePanel1.Controls.Add(this.EventValueLabel1);
            this.namePanel1.Controls.Add(this.eventType1);
            this.namePanel1.Controls.Add(this.eventValue1);
            this.namePanel1.Controls.Add(this.label1);
            this.namePanel1.Controls.Add(this.ObjectType1);
            this.namePanel1.Controls.Add(this.nameText1);
            this.namePanel1.Controls.Add(this.name1);
            this.namePanel1.Location = new System.Drawing.Point(12, 12);
            this.namePanel1.Name = "namePanel1";
            this.namePanel1.Size = new System.Drawing.Size(284, 104);
            this.namePanel1.TabIndex = 2;
            // 
            // ObjectType1
            // 
            this.ObjectType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ObjectType1.FormattingEnabled = true;
            this.ObjectType1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ObjectType1.Items.AddRange(new object[] {
            "All Lighting Events",
            "All Notes",
            "Blue Notes",
            "Bombs",
            "Lighting Events",
            "Red Notes",
            "Walls"});
            this.ObjectType1.Location = new System.Drawing.Point(148, 20);
            this.ObjectType1.Name = "ObjectType1";
            this.ObjectType1.Size = new System.Drawing.Size(121, 21);
            this.ObjectType1.Sorted = true;
            this.ObjectType1.TabIndex = 2;
            this.ObjectType1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Affected Object Type";
            // 
            // eventValue1
            // 
            this.eventValue1.Location = new System.Drawing.Point(216, 60);
            this.eventValue1.Name = "eventValue1";
            this.eventValue1.Size = new System.Drawing.Size(22, 20);
            this.eventValue1.TabIndex = 4;
            this.eventValue1.Visible = false;
            // 
            // eventType1
            // 
            this.eventType1.Location = new System.Drawing.Point(151, 59);
            this.eventType1.Name = "eventType1";
            this.eventType1.Size = new System.Drawing.Size(22, 20);
            this.eventType1.TabIndex = 5;
            this.eventType1.Visible = false;
            // 
            // EventValueLabel1
            // 
            this.EventValueLabel1.AutoSize = true;
            this.EventValueLabel1.Location = new System.Drawing.Point(213, 44);
            this.EventValueLabel1.Name = "EventValueLabel1";
            this.EventValueLabel1.Size = new System.Drawing.Size(65, 13);
            this.EventValueLabel1.TabIndex = 6;
            this.EventValueLabel1.Text = "Event Value";
            this.EventValueLabel1.Visible = false;
            // 
            // eventTypeLabel1
            // 
            this.eventTypeLabel1.AutoSize = true;
            this.eventTypeLabel1.Location = new System.Drawing.Point(145, 44);
            this.eventTypeLabel1.Name = "eventTypeLabel1";
            this.eventTypeLabel1.Size = new System.Drawing.Size(62, 13);
            this.eventTypeLabel1.TabIndex = 7;
            this.eventTypeLabel1.Text = "Event Type";
            this.eventTypeLabel1.Visible = false;
            // 
            // DataType1
            // 
            this.DataType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DataType1.FormattingEnabled = true;
            this.DataType1.IntegralHeight = false;
            this.DataType1.Items.AddRange(new object[] {
            "Float",
            "Float[3]",
            "Int",
            "Int[3]"});
            this.DataType1.Location = new System.Drawing.Point(6, 58);
            this.DataType1.Name = "DataType1";
            this.DataType1.Size = new System.Drawing.Size(100, 21);
            this.DataType1.Sorted = true;
            this.DataType1.TabIndex = 3;
            // 
            // DataTypeLabel1
            // 
            this.DataTypeLabel1.AutoSize = true;
            this.DataTypeLabel1.Location = new System.Drawing.Point(3, 42);
            this.DataTypeLabel1.Name = "DataTypeLabel1";
            this.DataTypeLabel1.Size = new System.Drawing.Size(57, 13);
            this.DataTypeLabel1.TabIndex = 8;
            this.DataTypeLabel1.Text = "Data Type";
            // 
            // DataNameLabel1
            // 
            this.DataNameLabel1.AutoSize = true;
            this.DataNameLabel1.Location = new System.Drawing.Point(43, 131);
            this.DataNameLabel1.Name = "DataNameLabel1";
            this.DataNameLabel1.Size = new System.Drawing.Size(61, 13);
            this.DataNameLabel1.TabIndex = 10;
            this.DataNameLabel1.Text = "Data Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(46, 147);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "njs";
            // 
            // ArguimentEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(308, 450);
            this.Controls.Add(this.DataNameLabel1);
            this.Controls.Add(this.namePanel1);
            this.Controls.Add(this.textBox1);
            this.Name = "ArguimentEditor";
            this.Text = "ArguimentEditor";
            this.namePanel1.ResumeLayout(false);
            this.namePanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name1;
        private System.Windows.Forms.Label nameText1;
        private System.Windows.Forms.Panel namePanel1;
        private System.Windows.Forms.ComboBox ObjectType1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DataTypeLabel1;
        private System.Windows.Forms.ComboBox DataType1;
        private System.Windows.Forms.Label eventTypeLabel1;
        private System.Windows.Forms.Label EventValueLabel1;
        private System.Windows.Forms.TextBox eventType1;
        private System.Windows.Forms.TextBox eventValue1;
        private System.Windows.Forms.Label DataNameLabel1;
        private System.Windows.Forms.TextBox textBox1;
    }
}