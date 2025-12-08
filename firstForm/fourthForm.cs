using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstForm
{
    public partial class fourthForm : Form
    {
        PrintDocument printDoc = new PrintDocument();

        public fourthForm()
        {
            InitializeComponent();
        }

        private void fourthForm_Load(object sender, EventArgs e)
        {

        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            pd.Document = printDoc;

            printDoc.PrintPage += PrintDoc_PrintPage;

            if (pd.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }
        }
        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            string text = "Пример текста.";
            e.Graphics.DrawString(text, new Font("Arial", 14), Brushes.Black, 50, 50);
        }

        private void mainBtn_Click(object sender, EventArgs e)
        {
            secondForm sf = new secondForm();
            sf.Show();
            this.Hide();
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            thirdForm tf = new thirdForm();
            tf.Show();
            this.Hide();
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
