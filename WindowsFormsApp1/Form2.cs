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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "salonKrasotiDataSet.Категория_услуги". При необходимости она может быть перемещена или удалена.
            this.категория_услугиTableAdapter.Fill(this.salonKrasotiDataSet.Категория_услуги);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "salonKrasotiDataSet.Услуги". При необходимости она может быть перемещена или удалена.
            this.услугиTableAdapter1.Fill(this.salonKrasotiDataSet.Услуги);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "salonKrasotiDataSet1.Услуги". При необходимости она может быть перемещена или удалена.
            this.услугиTableAdapter.Fill(this.salonKrasotiDataSet1.Услуги);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
