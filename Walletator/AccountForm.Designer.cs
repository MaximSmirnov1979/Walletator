namespace Walletator
{
    partial class AccountForm
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
            this.AddButton = new System.Windows.Forms.Button();
            this.deleteButton1 = new System.Windows.Forms.Button();
            this.accountComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addOperationButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.operationsListBox = new System.Windows.Forms.ListBox();
            this.button = new System.Windows.Forms.Button();
            this.sortGroupBox = new System.Windows.Forms.GroupBox();
            this.descCheckBox = new System.Windows.Forms.CheckBox();
            this.amountRadioButton = new System.Windows.Forms.RadioButton();
            this.CatRadioButton = new System.Windows.Forms.RadioButton();
            this.dateRadioButton = new System.Windows.Forms.RadioButton();
            this.defaultRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.filterButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.categoryFilterComboBox = new System.Windows.Forms.ComboBox();
            this.addRadioButton = new System.Windows.Forms.RadioButton();
            this.withdrawRadioButton = new System.Windows.Forms.RadioButton();
            this.allOperationRadioButton = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.amountFromTextBox = new System.Windows.Forms.TextBox();
            this.amountToTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.finishDateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.balanceFromTextBox = new System.Windows.Forms.TextBox();
            this.balanceToTextBox = new System.Windows.Forms.TextBox();
            this.sortGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddButton.Location = new System.Drawing.Point(12, 114);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(157, 48);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Добавить счет";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // deleteButton1
            // 
            this.deleteButton1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteButton1.Location = new System.Drawing.Point(189, 117);
            this.deleteButton1.Name = "deleteButton1";
            this.deleteButton1.Size = new System.Drawing.Size(157, 45);
            this.deleteButton1.TabIndex = 2;
            this.deleteButton1.Text = "Удалить счет";
            this.deleteButton1.UseVisualStyleBackColor = true;
            this.deleteButton1.Click += new System.EventHandler(this.deleteButton1_Click);
            // 
            // accountComboBox
            // 
            this.accountComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accountComboBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.accountComboBox.FormattingEnabled = true;
            this.accountComboBox.Location = new System.Drawing.Point(12, 49);
            this.accountComboBox.Name = "accountComboBox";
            this.accountComboBox.Size = new System.Drawing.Size(769, 45);
            this.accountComboBox.TabIndex = 3;
            this.accountComboBox.SelectedIndexChanged += new System.EventHandler(this.accountComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Счёт";
            // 
            // addOperationButton
            // 
            this.addOperationButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addOperationButton.Location = new System.Drawing.Point(369, 117);
            this.addOperationButton.Name = "addOperationButton";
            this.addOperationButton.Size = new System.Drawing.Size(157, 48);
            this.addOperationButton.TabIndex = 5;
            this.addOperationButton.Text = "Добавить операцию";
            this.addOperationButton.UseVisualStyleBackColor = true;
            this.addOperationButton.Click += new System.EventHandler(this.addOperationButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "Операции по счету";
            // 
            // operationsListBox
            // 
            this.operationsListBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.operationsListBox.FormattingEnabled = true;
            this.operationsListBox.ItemHeight = 30;
            this.operationsListBox.Location = new System.Drawing.Point(21, 388);
            this.operationsListBox.Name = "operationsListBox";
            this.operationsListBox.Size = new System.Drawing.Size(760, 124);
            this.operationsListBox.TabIndex = 7;
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button.Location = new System.Drawing.Point(572, 116);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(157, 48);
            this.button.TabIndex = 8;
            this.button.Text = "Удалить операцию";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // sortGroupBox
            // 
            this.sortGroupBox.Controls.Add(this.descCheckBox);
            this.sortGroupBox.Controls.Add(this.amountRadioButton);
            this.sortGroupBox.Controls.Add(this.CatRadioButton);
            this.sortGroupBox.Controls.Add(this.dateRadioButton);
            this.sortGroupBox.Controls.Add(this.defaultRadioButton);
            this.sortGroupBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sortGroupBox.Location = new System.Drawing.Point(21, 529);
            this.sortGroupBox.Name = "sortGroupBox";
            this.sortGroupBox.Size = new System.Drawing.Size(424, 78);
            this.sortGroupBox.TabIndex = 9;
            this.sortGroupBox.TabStop = false;
            this.sortGroupBox.Text = "Параметры сортировки";
            // 
            // descCheckBox
            // 
            this.descCheckBox.AutoSize = true;
            this.descCheckBox.Location = new System.Drawing.Point(319, 24);
            this.descCheckBox.Name = "descCheckBox";
            this.descCheckBox.Size = new System.Drawing.Size(110, 21);
            this.descCheckBox.TabIndex = 4;
            this.descCheckBox.Text = "По убыванию";
            this.descCheckBox.UseVisualStyleBackColor = true;
            this.descCheckBox.CheckedChanged += new System.EventHandler(this.sortRadioButton_CheckedChanged);
            // 
            // amountRadioButton
            // 
            this.amountRadioButton.AutoSize = true;
            this.amountRadioButton.Location = new System.Drawing.Point(185, 51);
            this.amountRadioButton.Name = "amountRadioButton";
            this.amountRadioButton.Size = new System.Drawing.Size(88, 21);
            this.amountRadioButton.TabIndex = 3;
            this.amountRadioButton.Text = "По сумме ";
            this.amountRadioButton.UseVisualStyleBackColor = true;
            this.amountRadioButton.CheckedChanged += new System.EventHandler(this.sortRadioButton_CheckedChanged);
            // 
            // CatRadioButton
            // 
            this.CatRadioButton.AutoSize = true;
            this.CatRadioButton.Location = new System.Drawing.Point(185, 24);
            this.CatRadioButton.Name = "CatRadioButton";
            this.CatRadioButton.Size = new System.Drawing.Size(107, 21);
            this.CatRadioButton.TabIndex = 2;
            this.CatRadioButton.Text = "По категории";
            this.CatRadioButton.UseVisualStyleBackColor = true;
            this.CatRadioButton.CheckedChanged += new System.EventHandler(this.sortRadioButton_CheckedChanged);
            // 
            // dateRadioButton
            // 
            this.dateRadioButton.AutoSize = true;
            this.dateRadioButton.Location = new System.Drawing.Point(21, 51);
            this.dateRadioButton.Name = "dateRadioButton";
            this.dateRadioButton.Size = new System.Drawing.Size(73, 21);
            this.dateRadioButton.TabIndex = 1;
            this.dateRadioButton.Text = "По дате";
            this.dateRadioButton.UseVisualStyleBackColor = true;
            this.dateRadioButton.CheckedChanged += new System.EventHandler(this.sortRadioButton_CheckedChanged);
            // 
            // defaultRadioButton
            // 
            this.defaultRadioButton.AutoSize = true;
            this.defaultRadioButton.Checked = true;
            this.defaultRadioButton.Location = new System.Drawing.Point(21, 24);
            this.defaultRadioButton.Name = "defaultRadioButton";
            this.defaultRadioButton.Size = new System.Drawing.Size(158, 21);
            this.defaultRadioButton.TabIndex = 0;
            this.defaultRadioButton.TabStop = true;
            this.defaultRadioButton.Text = "Стандартный порядок";
            this.defaultRadioButton.UseVisualStyleBackColor = true;
            this.defaultRadioButton.CheckedChanged += new System.EventHandler(this.sortRadioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.filterButton);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.categoryFilterComboBox);
            this.groupBox1.Controls.Add(this.addRadioButton);
            this.groupBox1.Controls.Add(this.withdrawRadioButton);
            this.groupBox1.Controls.Add(this.allOperationRadioButton);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.amountFromTextBox);
            this.groupBox1.Controls.Add(this.amountToTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.searchTextBox);
            this.groupBox1.Controls.Add(this.finishDateTimePicker2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.startDateTimePicker);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(21, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 167);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры поиска";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(554, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Сбросить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(451, 130);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(75, 23);
            this.filterButton.TabIndex = 15;
            this.filterButton.Text = "Найти";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(343, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Категории";
            // 
            // categoryFilterComboBox
            // 
            this.categoryFilterComboBox.FormattingEnabled = true;
            this.categoryFilterComboBox.Location = new System.Drawing.Point(422, 59);
            this.categoryFilterComboBox.Name = "categoryFilterComboBox";
            this.categoryFilterComboBox.Size = new System.Drawing.Size(207, 25);
            this.categoryFilterComboBox.TabIndex = 13;
            // 
            // addRadioButton
            // 
            this.addRadioButton.AutoSize = true;
            this.addRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addRadioButton.Location = new System.Drawing.Point(170, 132);
            this.addRadioButton.Name = "addRadioButton";
            this.addRadioButton.Size = new System.Drawing.Size(95, 21);
            this.addRadioButton.TabIndex = 12;
            this.addRadioButton.Text = "Зачисление";
            this.addRadioButton.UseVisualStyleBackColor = true;
            // 
            // withdrawRadioButton
            // 
            this.withdrawRadioButton.AutoSize = true;
            this.withdrawRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.withdrawRadioButton.Location = new System.Drawing.Point(292, 132);
            this.withdrawRadioButton.Name = "withdrawRadioButton";
            this.withdrawRadioButton.Size = new System.Drawing.Size(82, 21);
            this.withdrawRadioButton.TabIndex = 11;
            this.withdrawRadioButton.Text = "Списание";
            this.withdrawRadioButton.UseVisualStyleBackColor = true;
            // 
            // allOperationRadioButton
            // 
            this.allOperationRadioButton.AutoSize = true;
            this.allOperationRadioButton.Checked = true;
            this.allOperationRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.allOperationRadioButton.Location = new System.Drawing.Point(21, 132);
            this.allOperationRadioButton.Name = "allOperationRadioButton";
            this.allOperationRadioButton.Size = new System.Drawing.Size(108, 21);
            this.allOperationRadioButton.TabIndex = 10;
            this.allOperationRadioButton.TabStop = true;
            this.allOperationRadioButton.Text = "Все операции";
            this.allOperationRadioButton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(363, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "до";
            // 
            // amountFromTextBox
            // 
            this.amountFromTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.amountFromTextBox.Location = new System.Drawing.Point(108, 90);
            this.amountFromTextBox.Name = "amountFromTextBox";
            this.amountFromTextBox.Size = new System.Drawing.Size(217, 25);
            this.amountFromTextBox.TabIndex = 8;
            // 
            // amountToTextBox
            // 
            this.amountToTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.amountToTextBox.Location = new System.Drawing.Point(422, 90);
            this.amountToTextBox.Name = "amountToTextBox";
            this.amountToTextBox.Size = new System.Drawing.Size(207, 25);
            this.amountToTextBox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Сумма от ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Комментарий";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchTextBox.Location = new System.Drawing.Point(108, 59);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(217, 25);
            this.searchTextBox.TabIndex = 4;
            // 
            // finishDateTimePicker2
            // 
            this.finishDateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.finishDateTimePicker2.Location = new System.Drawing.Point(422, 22);
            this.finishDateTimePicker2.Name = "finishDateTimePicker2";
            this.finishDateTimePicker2.Size = new System.Drawing.Size(207, 25);
            this.finishDateTimePicker2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(363, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "по";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Период с ";
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startDateTimePicker.Location = new System.Drawing.Point(108, 22);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(217, 25);
            this.startDateTimePicker.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(488, 541);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 21);
            this.label9.TabIndex = 11;
            this.label9.Text = "Начало периода";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(661, 541);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 21);
            this.label10.TabIndex = 12;
            this.label10.Text = "Конец периода";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(572, 515);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 21);
            this.label11.TabIndex = 13;
            this.label11.Text = "Баланс на:";
            // 
            // balanceFromTextBox
            // 
            this.balanceFromTextBox.Location = new System.Drawing.Point(499, 576);
            this.balanceFromTextBox.Name = "balanceFromTextBox";
            this.balanceFromTextBox.ReadOnly = true;
            this.balanceFromTextBox.Size = new System.Drawing.Size(100, 23);
            this.balanceFromTextBox.TabIndex = 14;
            // 
            // balanceToTextBox
            // 
            this.balanceToTextBox.Location = new System.Drawing.Point(671, 578);
            this.balanceToTextBox.Name = "balanceToTextBox";
            this.balanceToTextBox.ReadOnly = true;
            this.balanceToTextBox.Size = new System.Drawing.Size(100, 23);
            this.balanceToTextBox.TabIndex = 15;
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 611);
            this.Controls.Add(this.balanceToTextBox);
            this.Controls.Add(this.balanceFromTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sortGroupBox);
            this.Controls.Add(this.button);
            this.Controls.Add(this.operationsListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addOperationButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.accountComboBox);
            this.Controls.Add(this.deleteButton1);
            this.Controls.Add(this.AddButton);
            this.Name = "AccountForm";
            this.Text = "AccountForm";
            this.sortGroupBox.ResumeLayout(false);
            this.sortGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button AddButton;
        private Button deleteButton1;
        private ComboBox accountComboBox;
        private Label label1;
        private Button addOperationButton;
        private Label label2;
        private ListBox operationsListBox;
        private Button button;
        private GroupBox sortGroupBox;
        private RadioButton defaultRadioButton;
        private CheckBox descCheckBox;
        private RadioButton amountRadioButton;
        private RadioButton CatRadioButton;
        private RadioButton dateRadioButton;
        private GroupBox groupBox1;
        private DateTimePicker startDateTimePicker;
        private DateTimePicker finishDateTimePicker2;
        private Label label4;
        private Label label3;
        private Label label5;
        private TextBox searchTextBox;
        private Label label7;
        private TextBox amountFromTextBox;
        private TextBox amountToTextBox;
        private Label label6;
        private RadioButton addRadioButton;
        private RadioButton withdrawRadioButton;
        private RadioButton allOperationRadioButton;
        private Label label8;
        private ComboBox categoryFilterComboBox;
        private Button button2;
        private Button filterButton;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox balanceFromTextBox;
        private TextBox balanceToTextBox;
    }
}