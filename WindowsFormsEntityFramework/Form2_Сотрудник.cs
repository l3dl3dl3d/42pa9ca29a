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
    public partial class Form2_Сотрудник : Form
    {
        HotelEntities db = new HotelEntities();
        public Form2_Сотрудник()
        {
            InitializeComponent();
            dataGridView1.DataSource = db.Сотрудник.ToList();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            HotelEntities db = new HotelEntities();
            Сотрудник сотрудник = new Сотрудник();
            сотрудник.Фамилия = textBox1.Text;
            сотрудник.Имя = textBox2.Text;
            сотрудник.Отчество = textBox3.Text;
            сотрудник.Возраст = Convert.ToInt32(textBox4.Text);
            сотрудник.Телефон = textBox5.Text;
            db.Сотрудник.Add(сотрудник);
            db.SaveChanges();
            MessageBox.Show("Запись добавлена!");
            dataGridView1.DataSource = db.Сотрудник.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HotelEntities db = new HotelEntities();
            Сотрудник сотрудник = db.Сотрудник.Find(Convert.ToInt32(dataGridView1.CurrentRow.Cells["Код_сотрудника"].Value));
            сотрудник.Фамилия = textBox1.Text;
            сотрудник.Имя = textBox2.Text;
            сотрудник.Отчество = textBox3.Text;
            сотрудник.Возраст = Convert.ToInt32(textBox4.Text);
            сотрудник.Телефон = textBox5.Text;
            db.SaveChanges();
            MessageBox.Show("Запись обновлена!");
            dataGridView1.DataSource = db.Сотрудник.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HotelEntities db = new HotelEntities();
            Сотрудник сотрудник = db.Сотрудник.Find(Convert.ToInt32(dataGridView1.CurrentRow.Cells["Код_сотрудника"].Value));
            if (сотрудник != null)
            {
                db.Сотрудник.Remove(сотрудник);
            }
            db.SaveChanges();
            dataGridView1.DataSource = db.Сотрудник.ToList();
            MessageBox.Show("Запись удалена!");
        }
    }
}
