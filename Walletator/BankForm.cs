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

namespace Walletator.Service
{
    public partial class BankForm : Form
    {
        private BankService bankService;
        public BankForm()
        {
            InitializeComponent();
            bankService = new BankService();
            viewBanks();
        }

        //вспомогательный метод вывода банков
        private void viewBanks()
        {
            try
            {
                List<Bank> banks = bankService.GetAll(); //получение банков
                BankListBox.Items.Clear(); //очистка старых данных
                foreach(Bank bank in banks) //записать новые данные в список
                {
                    BankListBox.Items.Add(bank);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Возникла ошибка при выводе банков: {ex.Message} ", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void addBankButton_Click(object sender, EventArgs e)
        {
            string bankName = BankNameTextBox.Text; //считываем имя банка из тексбокса
            
            //проверки
            if(bankName == "" || bankName == null)
            {
                MessageBox.Show("Введите имя банка", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                Bank bank = new Bank() { Name = bankName };
                bankService.Add(bank);
                viewBanks();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Возникла ошибка при добавлении банка: {ex.Message} ", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            int selectedBankIndex = BankListBox.SelectedIndex; //индекс выделенной строки
            if (selectedBankIndex < 0)
            {
                MessageBox.Show("Не выбран объект для изменений",
                    "Запрещено", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
                try
                {
                    string newBankBank = editTextBox.Text; //получаем новое имя банка
                    Bank updated = (Bank)BankListBox.SelectedItem;
                    updated.Name = newBankBank;
                    updated = bankService.Update(updated);
                    if(updated == null)
                    {
                        MessageBox.Show("Не удалось обновить банк");
                    }
                    else
                    {
                        viewBanks();
                        BankListBox.SelectedIndex = selectedBankIndex;
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Возникла ошибка при обновлении банка: {ex.Message} ", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BankListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedBankIndex = BankListBox.SelectedIndex; //индекс выделенной строки
            if(selectedBankIndex < 0)
            {
                editTextBox.Text = "";
            }
            else
            {
                editTextBox.Text = ((Bank)BankListBox.SelectedItem).Name;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int selectedBankIndex = BankListBox.SelectedIndex; //индекс выделенной строки
            if (selectedBankIndex < 0)
            {
                MessageBox.Show("Не выбран объект для удаления",
                    "Запрещено", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Bank deleted = (Bank)BankListBox.SelectedItem; 
                    deleted = bankService.RemoveById(deleted.Id);
                    if(deleted != null)
                    {
                        MessageBox.Show($"Банк {deleted} успешно удален");
                        viewBanks();
                    }
                    else
                    {
                        MessageBox.Show($"Не удалось удалить банк {deleted}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Возникла ошибка при удалении банка: {ex.Message} ", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
