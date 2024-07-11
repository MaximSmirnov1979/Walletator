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
    public partial class AccountForm : Form
    {
        private AccountService accountService;

        private OperationService operationService;

        
        
        public AccountForm()
        {
            InitializeComponent();
            accountService = new AccountService();
            operationService = new OperationService();
            viewCategory();
            viewAccounts();
            button2_Click(null, null);
        }

        // открыть форму метода добавления счета и добавить через неё новый счет
        private void AddButton_Click(object sender, EventArgs e)
        {
            // создаем объект формы
            AddAccountForm addAccountForm = new AddAccountForm();
            // открыть форму
            addAccountForm.ShowDialog();
            // из формы извлечем сохраненный аккаунт и сохраним его
            if(addAccountForm.Account == null)
            {
                MessageBox.Show("Данные не сохранены",
                    "Внимание",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                accountService.Add(addAccountForm.Account);
                viewAccounts();
            }
                
        }

        //вспомогательный метод фильтрации категории
        private void viewCategory()
        {
            CategoryService categoryService = new CategoryService();
            categoryFilterComboBox.Items.Add("");
            foreach (Category category in categoryService.GetAll())
            {
                categoryFilterComboBox.Items.Add(category.Name);
            }
        }

        //вспомогательный метод вывода аккаунтов
        private void viewAccounts()
        {
            try
            {
                List<Account> accounts = accountService.GetAll(); //получение аккаунтов
                accountComboBox.Items.Clear(); //очистка старых данных
                foreach (Account account in accounts) //записать новые данные в список
                {
                    accountComboBox.Items.Add(account);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Возникла ошибка при выводе счетов: {ex.Message} ", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //вспомогательный метод вывода операций
        private void viewOperations(int accountId)
        {
            try
            {
                //ПОДГОТОВКА ФИЛЬТРА
                DateTime periodFrom = startDateTimePicker.Value;
                DateTime periodTo = finishDateTimePicker2.Value;
                string comment = searchTextBox.Text;
                string category = categoryFilterComboBox.Text;
                string amountFrom = amountFromTextBox.Text;
                string amountTo = amountToTextBox.Text;
                bool isAdd = allOperationRadioButton.Checked || addRadioButton.Checked;
                bool isWithdraw = allOperationRadioButton.Checked || withdrawRadioButton.Checked;
                OperationFilterParam param = new OperationFilterParam(periodFrom, periodTo
                    , comment, category, amountFrom, amountTo, isAdd, isWithdraw);
                
                //ПОЛУЧЕНИЕ ОПЕРАЦИЙ
                List<Operation> operations = null;
                if (dateRadioButton.Checked)
                {
                    if (descCheckBox.Checked)
                    {
                        operations = operationService.FilterByAccountIdOrderByDayDesc(param, accountId);
                    }
                    else
                    {
                        operations = operationService.FilterByAccountIdOrderByDay(param, accountId);
                    }
                }
                else if(amountRadioButton.Checked)
                {
                    if (descCheckBox.Checked)
                    {
                        operations = operationService.FilterByAccountIdOrderByAmountDesc(param, accountId);
                    }
                    else
                    {
                        operations = operationService.FilterByAccountIdOrderByAmount(param, accountId);
                    }
                }
                else if (CatRadioButton.Checked)
                {
                    if (descCheckBox.Checked)
                    {
                        operations = operationService.FilterByAccountIdOrderByCategoryDesc(param, accountId);
                    }
                    else
                    {
                        operations = operationService.FilterByAccountIdOrderByCategory(param, accountId);
                    }
                }
                else
                {
                    if (descCheckBox.Checked)
                    {
                        operations = operationService.FilterByAccountIdDesc(param, accountId);
                    }
                    else
                    {
                        operations = operationService.FilterOperations(param, accountId);
                    }
                }
                
                //Вывод операций
                operationsListBox.Items.Clear(); //очистка старых данных
                foreach (Operation operation in operations) //записать новые данные в список
                {
                    operationsListBox.Items.Add(operation);

                }
                decimal balanceFrom = accountService.BalancePerDay(accountId, param.PeriodFrom.AddDays(-1));
                decimal balanceTo = accountService.BalancePerDay(accountId, param.PeriodTo);
                balanceFromTextBox.Text = balanceFrom.ToString();
                balanceToTextBox.Text = balanceTo.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Возникла ошибка при выводе операций: {ex.Message} ", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteButton1_Click(object sender, EventArgs e)
        {
            int selectedAccountIndex = accountComboBox.SelectedIndex; //индекс выделенной строки
            if (selectedAccountIndex < 0)
            {
                MessageBox.Show("Не выбран объект для удаления",
                    "Запрещено", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Account deleted = (Account)accountComboBox.SelectedItem;
                    deleted = accountService.RemoveById(deleted.Id);
                    if (deleted != null)
                    {
                        MessageBox.Show($"Банк {deleted} успешно удален");
                        viewAccounts();
                    }
                    else
                    {
                        MessageBox.Show($"Не удалось удалить счет {deleted}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Возникла ошибка при удалении счета: {ex.Message} ", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void addOperationButton_Click(object sender, EventArgs e)
        {
            if(accountComboBox.SelectedIndex != -1)
            {
                // получаем счет
                Account account = (Account)accountComboBox.SelectedItem;
                // создаем объект формы
                AddOperationsForm addOperationsForm = new AddOperationsForm(account);
                // открыть форму
                addOperationsForm.ShowDialog();

                // из формы извлечем сохраненный аккаунт и сохраним его
                if (addOperationsForm.Operation == null)
                {
                    MessageBox.Show("Данные не сохранены",
                        "Внимание",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    operationService.Add(addOperationsForm.Operation);

                    int tmp = accountComboBox.SelectedIndex;
                    viewAccounts();
                    accountComboBox.SelectedIndex = tmp;
                    
                }
            }
            else
            {
                MessageBox.Show("Счет не выбран",
                    "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }

        private void accountComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(accountComboBox.SelectedIndex != -1)
            {
                viewOperations(((Account)accountComboBox.SelectedItem).Id);
            }
            else
            {
                accountComboBox.Items.Clear();
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (operationsListBox.SelectedIndex != -1)
            {
                operationService.RemoveById(((Operation)operationsListBox.SelectedItem).Id);
                int tmp = accountComboBox.SelectedIndex;
                viewAccounts();
                accountComboBox.SelectedIndex = tmp;
                viewOperations(((Account)accountComboBox.SelectedItem).Id);

            }
            else
            {
                MessageBox.Show("Операция не выбрана");
            }
        }

        private void sortRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(accountComboBox.SelectedIndex != -1)
            {
                if (sender is RadioButton && !((RadioButton)sender).Checked)
                {
                    return;
                }
                if (sender is CheckBox && !((CheckBox)sender).Checked)
                {
                    return;
                }
                Account account = (Account)accountComboBox.SelectedItem;
                viewOperations(account.Id);
            }

        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            if (accountComboBox.SelectedIndex != -1)
            {
               
                Account account = (Account)accountComboBox.SelectedItem;
                viewOperations(account.Id);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            finishDateTimePicker2.Value = DateTime.Now;
            startDateTimePicker.Value = finishDateTimePicker2.Value.AddDays(-30);
            searchTextBox.Text = "";
            categoryFilterComboBox.Text = "";
            amountFromTextBox.Text = amountToTextBox.Text = "";
            allOperationRadioButton.Checked = true;
            filterButton_Click(sender, e);
        }
    }
}
