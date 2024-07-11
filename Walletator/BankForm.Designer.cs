namespace Walletator.Service
{
    partial class BankForm
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
            this.BankListBox = new System.Windows.Forms.ListBox();
            this.BankNameTextBox = new System.Windows.Forms.TextBox();
            this.addBankButton = new System.Windows.Forms.Button();
            this.editTextBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BankListBox
            // 
            this.BankListBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BankListBox.FormattingEnabled = true;
            this.BankListBox.ItemHeight = 37;
            this.BankListBox.Location = new System.Drawing.Point(12, 12);
            this.BankListBox.Name = "BankListBox";
            this.BankListBox.ScrollAlwaysVisible = true;
            this.BankListBox.Size = new System.Drawing.Size(495, 189);
            this.BankListBox.TabIndex = 0;
            this.BankListBox.SelectedIndexChanged += new System.EventHandler(this.BankListBox_SelectedIndexChanged);
            // 
            // BankNameTextBox
            // 
            this.BankNameTextBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BankNameTextBox.Location = new System.Drawing.Point(12, 207);
            this.BankNameTextBox.Name = "BankNameTextBox";
            this.BankNameTextBox.Size = new System.Drawing.Size(343, 43);
            this.BankNameTextBox.TabIndex = 1;
            // 
            // addBankButton
            // 
            this.addBankButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addBankButton.Location = new System.Drawing.Point(361, 207);
            this.addBankButton.Name = "addBankButton";
            this.addBankButton.Size = new System.Drawing.Size(146, 43);
            this.addBankButton.TabIndex = 2;
            this.addBankButton.Text = "Добавить";
            this.addBankButton.UseVisualStyleBackColor = true;
            this.addBankButton.Click += new System.EventHandler(this.addBankButton_Click);
            // 
            // editTextBox
            // 
            this.editTextBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editTextBox.Location = new System.Drawing.Point(12, 267);
            this.editTextBox.Name = "editTextBox";
            this.editTextBox.Size = new System.Drawing.Size(233, 43);
            this.editTextBox.TabIndex = 3;
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateButton.Location = new System.Drawing.Point(251, 267);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(125, 43);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "Изменить";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.Location = new System.Drawing.Point(382, 267);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(125, 43);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // BankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 358);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.editTextBox);
            this.Controls.Add(this.addBankButton);
            this.Controls.Add(this.BankNameTextBox);
            this.Controls.Add(this.BankListBox);
            this.Name = "BankForm";
            this.Text = "BankForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox BankListBox;
        private TextBox BankNameTextBox;
        private Button addBankButton;
        private TextBox editTextBox;
        private Button updateButton;
        private Button deleteButton;
    }
}