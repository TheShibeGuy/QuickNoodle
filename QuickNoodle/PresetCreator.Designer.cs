using System;

namespace QuickNoodle
{
    partial class PresetCreator
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
            this.presetList = new System.Windows.Forms.ComboBox();
            this.presetName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // presetList
            // 
            this.presetList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.presetList.FormattingEnabled = true;
            this.presetList.Items.AddRange(new object[] {
            "Position",
            "DefintionPosition",
            "Rotation",
            "LocalRotation",
            "Scale",
            "Dissolve",
            "DissolveArrow",
            "Color",
            "Interactable",
            "Time"});
            this.presetList.Location = new System.Drawing.Point(12, 52);
            this.presetList.Name = "presetList";
            this.presetList.Size = new System.Drawing.Size(121, 21);
            this.presetList.TabIndex = 0;
            this.presetList.SelectedIndexChanged += new System.EventHandler(this.presetList_SelectedIndexChanged);
            // 
            // presetName
            // 
            this.presetName.Location = new System.Drawing.Point(13, 26);
            this.presetName.Name = "presetName";
            this.presetName.Size = new System.Drawing.Size(100, 20);
            this.presetName.TabIndex = 1;
            this.presetName.Text = "Name";
            this.presetName.GotFocus += new System.EventHandler(this.presentName_GotFocus);
            this.presetName.LostFocus += new System.EventHandler(this.presentName_LostFocus);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(13, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Export Preset";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PresetCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 420);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.presetName);
            this.Controls.Add(this.presetList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PresetCreator";
            this.Text = "PresetCreator";
            this.Load += new System.EventHandler(this.PresetCreator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.ComboBox presetList;
        private System.Windows.Forms.TextBox presetName;
        private System.Windows.Forms.Button button1;
    }
}