using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace firstForm
{
    public partial class thirdForm : Form
    {
        private OleDbConnection conn;
        private OleDbDataAdapter adapter;
        private OleDbCommandBuilder builder;
        private DataTable table;

        string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\РАНХиГС\3 курс\Моделирование ПО\Database.accdb;";

        public thirdForm()
        {
            InitializeComponent();
        }

        private void thirdForm_Load(object sender, EventArgs e)
        {
            LoadClientsTable();
        }

        private void mainBtn_Click(object sender, EventArgs e)
        {
            secondForm sf = new secondForm();
            sf.Show();
            this.Hide();
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {

        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            fourthForm ft = new fourthForm();
            ft.Show();
            this.Hide();
        }

        private void LoadClientsTable()
        {
            try
            {
                conn = new OleDbConnection(connStr);

                string query = "SELECT ID, ClientName, DeviceName, ProblemDescription, RepairStatus, OrderDate FROM table1";

                adapter = new OleDbDataAdapter(query, conn);
                builder = new OleDbCommandBuilder(adapter);

                table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
                dataGridView1.Columns["ID"].ReadOnly = true;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных: " + ex.Message);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                adapter.Update(table);
                MessageBox.Show("Изменения успешно сохранены в базе.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
