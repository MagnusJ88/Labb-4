﻿namespace WorldOfWordcraftWinformsApp
{
    partial class WorldOfWordcraft
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.practiceButton = new System.Windows.Forms.Button();
            this.listBoxLists = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rightWrongLabel = new System.Windows.Forms.Label();
            this.resultLabel1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.toLanguageBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fromLanguageBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTipWoW = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1005, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.newToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.loadToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.loadToolStripMenuItem.Text = "Edit lists";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.newToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.newToolStripMenuItem.Text = "New list";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewListToolStripMenuItem_Click);
            // 
            // practiceButton
            // 
            this.practiceButton.BackColor = System.Drawing.SystemColors.Control;
            this.practiceButton.Enabled = false;
            this.practiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.practiceButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.practiceButton.Location = new System.Drawing.Point(179, 50);
            this.practiceButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.practiceButton.Name = "practiceButton";
            this.practiceButton.Size = new System.Drawing.Size(96, 29);
            this.practiceButton.TabIndex = 1;
            this.practiceButton.Text = "Practice";
            this.toolTipWoW.SetToolTip(this.practiceButton, "Click to start practice!");
            this.practiceButton.UseVisualStyleBackColor = false;
            this.practiceButton.Click += new System.EventHandler(this.PracticeButton_Click);
            // 
            // listBoxLists
            // 
            this.listBoxLists.BackColor = System.Drawing.SystemColors.Control;
            this.listBoxLists.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxLists.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listBoxLists.FormattingEnabled = true;
            this.listBoxLists.ItemHeight = 18;
            this.listBoxLists.Location = new System.Drawing.Point(17, 50);
            this.listBoxLists.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxLists.Name = "listBoxLists";
            this.listBoxLists.Size = new System.Drawing.Size(153, 166);
            this.listBoxLists.TabIndex = 2;
            this.toolTipWoW.SetToolTip(this.listBoxLists, "Click to select the list you wish to practice with");
            this.listBoxLists.SelectedIndexChanged += new System.EventHandler(this.ListBoxLists_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Available lists";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.rightWrongLabel);
            this.groupBox1.Controls.Add(this.resultLabel1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.submitButton);
            this.groupBox1.Controls.Add(this.inputBox);
            this.groupBox1.Controls.Add(this.toLanguageBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.fromLanguageBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(180, 79);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(810, 137);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // rightWrongLabel
            // 
            this.rightWrongLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rightWrongLabel.AutoSize = true;
            this.rightWrongLabel.Location = new System.Drawing.Point(11, 106);
            this.rightWrongLabel.Name = "rightWrongLabel";
            this.rightWrongLabel.Size = new System.Drawing.Size(81, 18);
            this.rightWrongLabel.TabIndex = 8;
            this.rightWrongLabel.Text = "right/wrong";
            this.rightWrongLabel.Visible = false;
            // 
            // resultLabel1
            // 
            this.resultLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resultLabel1.AutoSize = true;
            this.resultLabel1.Location = new System.Drawing.Point(523, 46);
            this.resultLabel1.Name = "resultLabel1";
            this.resultLabel1.Size = new System.Drawing.Size(44, 18);
            this.resultLabel1.TabIndex = 7;
            this.resultLabel1.Text = "result";
            this.resultLabel1.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(443, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = ":";
            // 
            // submitButton
            // 
            this.submitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.submitButton.BackColor = System.Drawing.SystemColors.Control;
            this.submitButton.Enabled = false;
            this.submitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.submitButton.Location = new System.Drawing.Point(689, 15);
            this.submitButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(96, 32);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Submit";
            this.toolTipWoW.SetToolTip(this.submitButton, "Click to see if your guess was correct!");
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // inputBox
            // 
            this.inputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputBox.Enabled = false;
            this.inputBox.Location = new System.Drawing.Point(464, 19);
            this.inputBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(193, 24);
            this.inputBox.TabIndex = 4;
            this.toolTipWoW.SetToolTip(this.inputBox, "Enter the word you think is correct here!");
            this.inputBox.TextChanged += new System.EventHandler(this.InputBox_TextChanged);
            this.inputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputBox_KeyDown);
            // 
            // toLanguageBox
            // 
            this.toLanguageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toLanguageBox.Location = new System.Drawing.Point(279, 19);
            this.toLanguageBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.toLanguageBox.Name = "toLanguageBox";
            this.toLanguageBox.ReadOnly = true;
            this.toLanguageBox.Size = new System.Drawing.Size(156, 24);
            this.toLanguageBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(250, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "to";
            // 
            // fromLanguageBox
            // 
            this.fromLanguageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fromLanguageBox.Location = new System.Drawing.Point(89, 19);
            this.fromLanguageBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fromLanguageBox.Name = "fromLanguageBox";
            this.fromLanguageBox.ReadOnly = true;
            this.fromLanguageBox.Size = new System.Drawing.Size(153, 24);
            this.fromLanguageBox.TabIndex = 1;
            this.fromLanguageBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(11, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Translate ";
            // 
            // WorldOfWordcraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1005, 240);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxLists);
            this.Controls.Add(this.practiceButton);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1023, 287);
            this.Name = "WorldOfWordcraft";
            this.Text = "World of Wordcraft";
            this.Load += new System.EventHandler(this.WorldOfWordcraft_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.Button practiceButton;
        private System.Windows.Forms.ListBox listBoxLists;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.TextBox toLanguageBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fromLanguageBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resultLabel1;
        private System.Windows.Forms.Label rightWrongLabel;
        private System.Windows.Forms.ToolTip toolTipWoW;
    }
}

