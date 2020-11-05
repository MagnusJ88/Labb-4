namespace WordsWinformsApp
{
    partial class Edit
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.dataGridViewWords = new System.Windows.Forms.DataGridView();
            this.saveButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.toolTipEdit = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWords)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox.BackColor = System.Drawing.SystemColors.Control;
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 18;
            this.listBox.Location = new System.Drawing.Point(12, 38);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(179, 382);
            this.listBox.TabIndex = 0;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // dataGridViewWords
            // 
            this.dataGridViewWords.AllowUserToAddRows = false;
            this.dataGridViewWords.AllowUserToDeleteRows = false;
            this.dataGridViewWords.AllowUserToOrderColumns = true;
            this.dataGridViewWords.AllowUserToResizeColumns = false;
            this.dataGridViewWords.AllowUserToResizeRows = false;
            this.dataGridViewWords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewWords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWords.Location = new System.Drawing.Point(197, 38);
            this.dataGridViewWords.Name = "dataGridViewWords";
            this.dataGridViewWords.ReadOnly = true;
            this.dataGridViewWords.RowHeadersWidth = 51;
            this.dataGridViewWords.RowTemplate.Height = 24;
            this.dataGridViewWords.Size = new System.Drawing.Size(773, 382);
            this.dataGridViewWords.TabIndex = 1;
            this.dataGridViewWords.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewWords_CellClick);
            this.dataGridViewWords.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewWords_RowHeaderMouseClick);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveButton.BackColor = System.Drawing.SystemColors.Control;
            this.saveButton.Enabled = false;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveButton.Location = new System.Drawing.Point(93, 427);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 35);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.toolTipEdit.SetToolTip(this.saveButton, "Saves changes to disk");
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editButton.BackColor = System.Drawing.SystemColors.Control;
            this.editButton.Enabled = false;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.editButton.Location = new System.Drawing.Point(12, 427);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 35);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit";
            this.toolTipEdit.SetToolTip(this.editButton, "Enables editing on your chosen list");
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Available lists";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(197, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(674, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Add words here! Make sure to enter a value in each cell! If a cell is left blank," +
    " the row can not be saved!";
            this.label2.Visible = false;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.BackColor = System.Drawing.SystemColors.Control;
            this.deleteButton.Enabled = false;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.deleteButton.Location = new System.Drawing.Point(867, 427);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(103, 35);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete row";
            this.toolTipEdit.SetToolTip(this.deleteButton, "Select a row by clicking row header");
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(298, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(521, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Selecting a different list or closing this window without saving will discard cha" +
    "nges!";
            this.label3.Visible = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(175, 427);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(88, 35);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Close";
            this.toolTipEdit.SetToolTip(this.cancelButton, "Closes window without saving changes");
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(982, 473);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dataGridViewWords);
            this.Controls.Add(this.listBox);
            this.MinimumSize = new System.Drawing.Size(1000, 520);
            this.Name = "Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit lists";
            this.Load += new System.EventHandler(this.Load_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.DataGridView dataGridViewWords;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ToolTip toolTipEdit;
    }
}