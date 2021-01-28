namespace QuickNoodle
{
    partial class ArgumentControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DataNameLabel1 = new System.Windows.Forms.Label();
            this.DataTypeLabel1 = new System.Windows.Forms.Label();
            this.DataType1 = new System.Windows.Forms.ComboBox();
            this.dataName1 = new System.Windows.Forms.TextBox();
            this.eventTypeLabel1 = new System.Windows.Forms.Label();
            this.EventValueLabel1 = new System.Windows.Forms.Label();
            this.eventType1 = new System.Windows.Forms.TextBox();
            this.eventValue1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ObjectType1 = new System.Windows.Forms.ComboBox();
            this.nameText1 = new System.Windows.Forms.Label();
            this.name1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DataNameLabel1
            // 
            this.DataNameLabel1.AutoSize = true;
            this.DataNameLabel1.Location = new System.Drawing.Point(8, 96);
            this.DataNameLabel1.Name = "DataNameLabel1";
            this.DataNameLabel1.Size = new System.Drawing.Size(61, 13);
            this.DataNameLabel1.TabIndex = 22;
            this.DataNameLabel1.Text = "Data Name";
            // 
            // DataTypeLabel1
            // 
            this.DataTypeLabel1.AutoSize = true;
            this.DataTypeLabel1.Location = new System.Drawing.Point(5, 44);
            this.DataTypeLabel1.Name = "DataTypeLabel1";
            this.DataTypeLabel1.Size = new System.Drawing.Size(57, 13);
            this.DataTypeLabel1.TabIndex = 20;
            this.DataTypeLabel1.Text = "Data Type";
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
            this.DataType1.Location = new System.Drawing.Point(8, 60);
            this.DataType1.Name = "DataType1";
            this.DataType1.SelectedIndex = 0;
            this.DataType1.Size = new System.Drawing.Size(100, 21);
            this.DataType1.Sorted = true;
            this.DataType1.TabIndex = 14;
            // 
            // dataName1
            // 
            this.dataName1.Location = new System.Drawing.Point(75, 93);
            this.dataName1.Name = "dataName1";
            this.dataName1.Size = new System.Drawing.Size(196, 20);
            this.dataName1.TabIndex = 21;
            this.dataName1.Text = "";
            this.dataName1.TextChanged += new System.EventHandler(this.dataName1_TextChanged);
            // 
            // eventTypeLabel1
            // 
            this.eventTypeLabel1.AutoSize = true;
            this.eventTypeLabel1.Location = new System.Drawing.Point(147, 46);
            this.eventTypeLabel1.Name = "eventTypeLabel1";
            this.eventTypeLabel1.Size = new System.Drawing.Size(62, 13);
            this.eventTypeLabel1.TabIndex = 19;
            this.eventTypeLabel1.Text = "Event Type";
            this.eventTypeLabel1.Visible = false;
            // 
            // EventValueLabel1
            // 
            this.EventValueLabel1.AutoSize = true;
            this.EventValueLabel1.Location = new System.Drawing.Point(215, 46);
            this.EventValueLabel1.Name = "EventValueLabel1";
            this.EventValueLabel1.Size = new System.Drawing.Size(65, 13);
            this.EventValueLabel1.TabIndex = 18;
            this.EventValueLabel1.Text = "Event Value";
            this.EventValueLabel1.Visible = false;
            // 
            // eventType1
            // 
            this.eventType1.Location = new System.Drawing.Point(153, 61);
            this.eventType1.Name = "eventType1";
            this.eventType1.Size = new System.Drawing.Size(22, 20);
            this.eventType1.TabIndex = 17;
            this.eventType1.Visible = false;
            // 
            // eventValue1
            // 
            this.eventValue1.Location = new System.Drawing.Point(218, 62);
            this.eventValue1.Name = "eventValue1";
            this.eventValue1.Size = new System.Drawing.Size(22, 20);
            this.eventValue1.TabIndex = 16;
            this.eventValue1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Affected Object Type";
            // 
            // ObjectType1
            // 
            this.ObjectType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ObjectType1.FormattingEnabled = true;
            this.ObjectType1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ObjectType1.Items.AddRange(new object[] {
            "All Lighting Events",
            "All Note Objects",
            "All Notes",
            "All Objects",
            "Blue Notes",
            "Bombs",
            "Lighting Events",
            "Red Notes",
            "Walls"});
            this.ObjectType1.Location = new System.Drawing.Point(150, 22);
            this.ObjectType1.Name = "ObjectType1";
            this.ObjectType1.Size = new System.Drawing.Size(121, 21);
            this.ObjectType1.Sorted = true;
            this.ObjectType1.TabIndex = 13;
            this.ObjectType1.SelectedIndex = 0;
            this.ObjectType1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // nameText1
            // 
            this.nameText1.AutoSize = true;
            this.nameText1.Location = new System.Drawing.Point(5, 6);
            this.nameText1.Name = "nameText1";
            this.nameText1.Size = new System.Drawing.Size(35, 13);
            this.nameText1.TabIndex = 12;
            this.nameText1.Text = "Name";
            // 
            // name1
            // 
            this.name1.Location = new System.Drawing.Point(8, 22);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(100, 20);
            this.name1.TabIndex = 11;
            this.name1.Text = "";
            this.name1.TextChanged += new System.EventHandler(this.nameBox1_TextChanged);
            // 
            // ArgumentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DataNameLabel1);
            this.Controls.Add(this.DataTypeLabel1);
            this.Controls.Add(this.DataType1);
            this.Controls.Add(this.dataName1);
            this.Controls.Add(this.eventTypeLabel1);
            this.Controls.Add(this.EventValueLabel1);
            this.Controls.Add(this.eventType1);
            this.Controls.Add(this.eventValue1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ObjectType1);
            this.Controls.Add(this.nameText1);
            this.Controls.Add(this.name1);
            this.Name = "ArgumentControl";
            this.Size = new System.Drawing.Size(284, 116);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DataNameLabel1;
        private System.Windows.Forms.Label DataTypeLabel1;
        private System.Windows.Forms.ComboBox DataType1;
        private System.Windows.Forms.TextBox dataName1;
        private System.Windows.Forms.Label eventTypeLabel1;
        private System.Windows.Forms.Label EventValueLabel1;
        private System.Windows.Forms.TextBox eventType1;
        private System.Windows.Forms.TextBox eventValue1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ObjectType1;
        private System.Windows.Forms.Label nameText1;
        private System.Windows.Forms.TextBox name1;
    }
}
