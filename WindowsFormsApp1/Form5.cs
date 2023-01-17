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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "salonKrasotiDataSet.Предстоящие_записи". При необходимости она может быть перемещена или удалена.
            this.предстоящие_записиTableAdapter.Fill(this.salonKrasotiDataSet.Предстоящие_записи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "salonKrasotiDataSet.Категория_услуги". При необходимости она может быть перемещена или удалена.
            this.категория_услугиTableAdapter.Fill(this.salonKrasotiDataSet.Категория_услуги);

        }
    }
}
