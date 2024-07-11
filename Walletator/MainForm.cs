using Walletator.Service;

namespace Walletator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void accountButton_Click(object sender, EventArgs e)
        {
            AccountForm accountForm = new AccountForm();
            Hide();
            accountForm.ShowDialog();
            Show();
        }

        private void banksButton_Click(object sender, EventArgs e)
        {
            BankForm bankForm = new BankForm();// вызываем форму BankForm
            Hide(); //скрываем основную форму
            bankForm.ShowDialog();
            Show();//показываем форму
            
        }

        private void categoryButton_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();// вызываем форму CategoryForm
            Hide(); //скрываем основную форму
            categoryForm.ShowDialog();
            Show();//показываем форму
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //закрыть приложение
            Close();
        }

        

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //обработка события закрытия формы
            DialogResult result = MessageBox.Show(
                "Вы действительно хотите выйти?",
                "Выход",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}