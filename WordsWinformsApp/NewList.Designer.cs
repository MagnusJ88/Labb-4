namespace WordsWinformsApp
{
    partial class NewList
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.languageTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saveButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.toolTipNew = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(13, 34);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(135, 22);
            this.textBoxName.TabIndex = 0;
            this.toolTipNew.SetToolTip(this.textBoxName, "Name of the list you wish to create");
            this.textBoxName.TextChanged += new System.EventHandler(this.TextBoxName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Languages";
            // 
            // languageTextBox
            // 
            this.languageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.languageTextBox.Enabled = false;
            this.languageTextBox.Location = new System.Drawing.Point(13, 84);
            this.languageTextBox.Multiline = true;
            this.languageTextBox.Name = "languageTextBox";
            this.languageTextBox.Size = new System.Drawing.Size(135, 267);
            this.languageTextBox.TabIndex = 1;
            this.toolTipNew.SetToolTip(this.languageTextBox, "Add a language, one per row");
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(174, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(614, 404);
            this.dataGridView1.TabIndex = 5;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(12, 386);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(136, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save new list";
            this.toolTipNew.SetToolTip(this.saveButton, "Saves your new list to disk");
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addButton.Enabled = false;
            this.addButton.Location = new System.Drawing.Point(13, 357);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(136, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add words";
            this.toolTipNew.SetToolTip(this.addButton, "Klick to enable a datagrid which allows you to add words");
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(174, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Add words here! All rows must be complete!";
            this.label3.Visible = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.Location = new System.Drawing.Point(12, 415);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(136, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.toolTipNew.SetToolTip(this.cancelButton, "Closes the window without saving changes");
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NewList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.languageTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "NewList";
            this.Text = "New list";
            this.Load += new System.EventHandler(this.NewList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox languageTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ToolTip toolTipNew;
    }
}