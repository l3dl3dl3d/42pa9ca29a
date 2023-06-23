using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEntityFramework
{
    public partial class Form2_Формы : Form
    {
        public Form2_Формы()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2_Клиент form2_Клиент = new Form2_Клиент();
            form2_Клиент.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2_Сотрудник form2_Сотрудник = new Form2_Сотрудник();
            form2_Сотрудник.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2_Номер form2_Номер = new Form2_Номер();
            form2_Номер.Show();
        }
    }
}
