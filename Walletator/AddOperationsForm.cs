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
    public partial class AddOperationsForm : Form
    {
        private Account account;

        private Operation? operation = null;

        public AddOperationsForm(Account account)
        {

            InitializeComponent();
            this.account = account;
            titleLabel.Text = $"Добавление операции по счету {account.Title}";
            identityLabel.Text = $"Номер счета: {(account.Identity == null || account.Identity == ""?"отсутствует": account.Identity)}";
            balanceLabel.Text = $"Текущий баланс: {account.Balance}";
            LoadCategories();

        }
        //геттер
        public Operation? Operation { get { return operation; } }

        // метод загрузки категорий
        private void LoadCategories()
        {
            CategoryService categoryService = new CategoryService(); // создаем сервис для работы с категориями
            List<Category> categories = categoryService.GetAll();
            foreach(Category category in categories)
            {
                categoriesComboBox.Items.Add(category);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // проверка комментария
            string comment = commentTextBox.Text;
            if(comment == null || comment.Length == 0)
            {
                MessageBox.Show("Добавьте комментарий к операции",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            // проверка суммы операции
            decimal amount;
            if (decimal.TryParse(amountTextBox.Text, out amount))
            {
                if(amount > 0)
                {
                    if (withdrawRadioButton.Checked) 
                    {
                        // списание, необходимо сменить знак операции и проверить баланс
                        amount = -amount;
                        
                    }
                }
                else
                {
                    MessageBox.Show("Величина операции должна иметь положительное значение",
                                        "Ошибка",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Не корректный формат данных операции",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            // проверка даты операции
            DateTime day = dayCalendar.Value;
            if(day > DateTime.Now)
            {
                MessageBox.Show("нельзя зарегистрировать операцию будущим числом",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;

            }
            // проверка категории операции
            int categoryId;
            if(categoriesComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("необходимо выбрать категорию",
                                    "Ошибка",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                return;
            }
            else
            {
                categoryId = ((Category)categoriesComboBox.SelectedItem).Id;
            }

            //        формируем операцию
            operation = new Operation()
            {
                Comment = comment,
                Amount = amount,
                Day = day,
                AccountId = account.Id,
                CategoryId = categoryId
                
            };
            Close();
        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
