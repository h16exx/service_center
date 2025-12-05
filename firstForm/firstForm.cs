using System;
using System.Windows.Forms;

namespace firstForm
{
    public partial class firstForm : Form
    {

        private const string CorrectLogin = "123";
        private const string CorrectPassword = "12345";

        public firstForm()
        {
            InitializeComponent();
            textBox3.PasswordChar = '*';
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            string enteredLogin = textBox4.Text;
            string enteredPassword = textBox3.Text;

            if (enteredLogin == CorrectLogin && enteredPassword == CorrectPassword)
            {
                secondForm nextForm = new secondForm();
                nextForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Авторизация не удалась. Программа будет закрыта.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }



        private void firstForm_Load(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        
    }
}
