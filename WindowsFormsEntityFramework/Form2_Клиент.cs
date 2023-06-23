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
    public partial class Form2_Клиент : Form
    {
        HotelEntities db = new HotelEntities();
        public Form2_Клиент()
        {
            InitializeComponent();
            dataGridView1.DataSource = db.Клиент.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HotelEntities db = new HotelEntities();
            Клиент клиент = new Клиент();
            клиент.Фамилия = textBox1.Text;
            клиент.Имя = textBox2.Text;
            клиент.Отчество = textBox3.Text;
            клиент.Возраст = Convert.ToInt32(textBox4.Text);
            клиент.Телефон = textBox5.Text;
            db.Клиент.Add(клиент);
            db.SaveChanges();
            MessageBox.Show("Запись добавлена!");
            dataGridView1.DataSource = db.Клиент.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HotelEntities db = new HotelEntities();
            Клиент клиент = db.Клиент.Find(Convert.ToInt32(dataGridView1.CurrentRow.Cells["Код_клиента"].Value));
            клиент.Фамилия = textBox1.Text;
            клиент.Имя = textBox2.Text;
            клиент.Отчество = textBox3.Text;
            клиент.Возраст = Convert.ToInt32(textBox4.Text);
            клиент.Телефон = textBox5.Text;
            db.SaveChanges();
            MessageBox.Show("Запись обновлена!");
            dataGridView1.DataSource = db.Клиент.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HotelEntities db = new HotelEntities();
            Клиент клиент = db.Клиент.Find(Convert.ToInt32(dataGridView1.CurrentRow.Cells["Код_клиента"].Value));
            if (клиент != null)
            {
                db.Клиент.Remove(клиент);
            }
            db.SaveChanges();
            dataGridView1.DataSource = db.Клиент.ToList();
            MessageBox.Show("Запись удалена!");
        }
    }
}
