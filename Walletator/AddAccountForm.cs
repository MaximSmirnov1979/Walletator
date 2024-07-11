using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Walletator.Model;
using Walletator.Service;

namespace Walletator
{
    public partial class AddAccountForm : Form
    {
        private BankService bankService;
        public Account? Account { get; set; } = null;
        public AddAccountForm()
        {
            InitializeComponent();
            bankService = new BankService();
            bankComboBox.Items.AddRange(bankService.GetAll().ToArray());
            bankComboBox.SelectedIndex = 0;
        }

        

        private void CancelButton_Click(object sender, EventArgs e)
        {
           DialogResult dialogResult = MessageBox.Show("Вы действительно хотите выйти",
                    "Есть не сохраненные данные",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
            if(dialogResult == DialogResult.Yes)
            {
                Close();
            }
            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //проверка ввода описания
            string title = titleTextBox.Text;
            if(title == null || title == "")
            {
                MessageBox.Show("Пустое название не допустимо!", 
                    "Ошибка", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
                return;
            }

            //проверка ввода баланса
            decimal balance;
            try 
            {
                balance = Convert.ToDecimal(balanceTextBox.Text);
            }
            catch {
                MessageBox.Show("Не корректный ввод баланса",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }

            Account = new Account()
            {
                Title = title,
                Identity = identitytextBox.Text,
                Balance = balance,
                BankId = ((Bank)bankComboBox.SelectedItem).Id
                
            };
            Close();
        }
    }
}
