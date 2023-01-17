using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "salonKrasotiDataSet1.Услуги". При необходимости она может быть перемещена или удалена.
            this.услугиTableAdapter.Fill(this.salonKrasotiDataSet1.Услуги);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "salonKrasotiDataSet1.Предстоящие_записи". При необходимости она может быть перемещена или удалена.
            this.предстоящие_записиTableAdapter.Fill(this.salonKrasotiDataSet1.Предстоящие_записи);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 newForm = new Form5();
            newForm.Show();
        }
    }
}
