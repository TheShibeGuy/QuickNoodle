namespace QuickNoodle
{
    partial class ArgumentEditor
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
            this.argumentControl2 = new QuickNoodle.ArgumentControl();
            this.argumentControl1 = new QuickNoodle.ArgumentControl();
            this.add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // argumentControl2
            // 
            this.argumentControl2.ArgName = "bombWorldRotation";
            this.argumentControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.argumentControl2.DataName = "_worldRotation";
            this.argumentControl2.DataType = DataType.Float3;
            this.argumentControl2.EventType = -1;
            this.argumentControl2.EventValue = -1;
            this.argumentControl2.Location = new System.Drawing.Point(10, 135);
            this.argumentControl2.Name = "argumentControl2";
            this.argumentControl2.Size = new System.Drawing.Size(284, 116);
            this.argumentControl2.TabIndex = 4;
            args.AddLast(this.argumentControl2);
            // 
            // argumentControl1
            // 
            this.argumentControl1.ArgName = "wallJumpSpeed";
            this.argumentControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.argumentControl1.DataName = "_noteJumpSpeed";
            this.argumentControl1.DataType = DataType.Float;
            this.argumentControl1.EventType = -1;
            this.argumentControl1.EventValue = -1;
            this.argumentControl1.Location = new System.Drawing.Point(12, 12);
            this.argumentControl1.Name = "argumentControl1";
            this.argumentControl1.Size = new System.Drawing.Size(284, 116);
            this.argumentControl1.TabIndex = 3;
            args.AddFirst(this.argumentControl1);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(125, 257);
            this.add.Name = "add";
            this.add.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.add.Size = new System.Drawing.Size(25, 25);
            this.add.TabIndex = 5;
            this.add.Text = "+";
            this.add.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // ArgumentEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(308, 450);
            this.Controls.Add(this.add);
            this.Controls.Add(this.argumentControl2);
            this.Controls.Add(this.argumentControl1);
            this.Name = "ArgumentEditor";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "ArgumentEditor";
            this.ResumeLayout(false);

        }

        #endregion

        private ArgumentControl argumentControl1;
        private ArgumentControl argumentControl2;
        private System.Windows.Forms.Button add;
    }
}