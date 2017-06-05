﻿namespace App.UI.PhaseThree
{
    partial class ChooseRoom
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
            this.comboBoxSections = new System.Windows.Forms.ComboBox();
            this.textBoxRoomName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddRoomName = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxSections
            // 
            this.comboBoxSections.FormattingEnabled = true;
            this.comboBoxSections.Location = new System.Drawing.Point(24, 24);
            this.comboBoxSections.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxSections.Name = "comboBoxSections";
            this.comboBoxSections.Size = new System.Drawing.Size(92, 21);
            this.comboBoxSections.TabIndex = 0;
            // 
            // textBoxRoomName
            // 
            this.textBoxRoomName.Location = new System.Drawing.Point(24, 78);
            this.textBoxRoomName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRoomName.Name = "textBoxRoomName";
            this.textBoxRoomName.Size = new System.Drawing.Size(111, 20);
            this.textBoxRoomName.TabIndex = 1;
            this.textBoxRoomName.TextChanged += new System.EventHandler(this.textBoxRoomName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Room name";
            // 
            // btnAddRoomName
            // 
            this.btnAddRoomName.Location = new System.Drawing.Point(162, 76);
            this.btnAddRoomName.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddRoomName.Name = "btnAddRoomName";
            this.btnAddRoomName.Size = new System.Drawing.Size(120, 23);
            this.btnAddRoomName.TabIndex = 3;
            this.btnAddRoomName.Text = "Add";
            this.btnAddRoomName.UseVisualStyleBackColor = true;
            this.btnAddRoomName.Click += new System.EventHandler(this.btnAddRoomName_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(24, 113);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(103, 39);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(162, 113);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(120, 39);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // ChooseRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 164);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.btnAddRoomName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRoomName);
            this.Controls.Add(this.comboBoxSections);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(317, 203);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(317, 203);
            this.Name = "ChooseRoom";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ChooseRoom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSections;
        private System.Windows.Forms.TextBox textBoxRoomName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddRoomName;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button btnSubmit;
    }
}