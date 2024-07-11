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
            BankForm bankForm = new BankForm();// �������� ����� BankForm
            Hide(); //�������� �������� �����
            bankForm.ShowDialog();
            Show();//���������� �����
            
        }

        private void categoryButton_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();// �������� ����� CategoryForm
            Hide(); //�������� �������� �����
            categoryForm.ShowDialog();
            Show();//���������� �����
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //������� ����������
            Close();
        }

        

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //��������� ������� �������� �����
            DialogResult result = MessageBox.Show(
                "�� ������������� ������ �����?",
                "�����",
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