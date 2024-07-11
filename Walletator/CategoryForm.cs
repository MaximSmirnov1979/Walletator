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
    public partial class CategoryForm : Form
    {
        private CategoryService categoryService;
        public CategoryForm()
        {
            InitializeComponent();
            categoryService = new CategoryService();
            viewCategories();
        }

        //вспомогательный метод вывода категорий
        private void viewCategories()
        {
            try
            {
                List<Category> categories = categoryService.GetAll(); //получение категорий
                CategoryListBox.Items.Clear(); //очистка старых данных
                foreach (Category category in categories) //записать новые данные в список
                {
                    CategoryListBox.Items.Add(category);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Возникла ошибка при выводе категорий: {ex.Message} ", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string categoryName = CategoryNameTextBox.Text; //считываем наименование категории из тексбокса

            //проверки
            if (categoryName == "" || categoryName == null)
            {
                MessageBox.Show("Введите наименование", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                Category category = new Category() { Name = categoryName };
                categoryService.Add(category);
                viewCategories();
                CategoryListBox.SelectedIndex = CategoryListBox.Items.Count-1; //перемещаем фокус на добавленный элемент

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Возникла ошибка при добавлении категории: {ex.Message} ", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            int selectedCategoryIndex = CategoryListBox.SelectedIndex; //индекс выделенной строки
            if (selectedCategoryIndex < 0)
            {
                MessageBox.Show("Не выбран объект для изменений",
                    "Запрещено", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                try
                {
                    string newCategoryCategory = editTextBox.Text; //получаем новое наименование категории
                    Category updated = (Category)CategoryListBox.SelectedItem;
                    updated.Name = newCategoryCategory;
                    updated = categoryService.Update(updated);
                    if (updated == null)
                    {
                        MessageBox.Show("Не удалось обновить категорию");
                    }
                    else
                    {
                        viewCategories();
                        CategoryListBox.SelectedIndex = selectedCategoryIndex;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Возникла ошибка при обновлении банка: {ex.Message} ", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CategoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedCategoryIndex = CategoryListBox.SelectedIndex; //индекс выделенной строки
            if (selectedCategoryIndex < 0)
            {
                editTextBox.Text = "";
            }
            else
            {
                editTextBox.Text = ((Category)CategoryListBox.SelectedItem).Name;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int selectedCategoryIndex = CategoryListBox.SelectedIndex; //индекс выделенной строки
            if (selectedCategoryIndex < 0)
            {
                MessageBox.Show("Не выбран объект для удаления",
                    "Запрещено", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Category deleted = (Category)CategoryListBox.SelectedItem;
                    deleted = categoryService.RemoveById(deleted.Id);
                    if (deleted != null)
                    {
                        MessageBox.Show($"Категория {deleted} успешно удалена");
                        viewCategories();
                    }
                    else
                    {
                        MessageBox.Show($"Не удалось удалить категорию {deleted}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Возникла ошибка при удалении категории: {ex.Message} ", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
