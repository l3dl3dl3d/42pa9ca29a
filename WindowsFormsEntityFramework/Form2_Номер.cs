using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsEntityFramework
{
    public partial class Form2_Номер : Form
    {
        HotelEntities db = new HotelEntities();
        public Form2_Номер()
        {
            InitializeComponent();
            dataGridView1.DataSource = db.Номер.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HotelEntities db = new HotelEntities();
            Номер номер = new Номер();
            номер.Вместимость = textBox1.Text;
            номер.Стоимость = Convert.ToInt32(textBox2.Text);
            номер.Статус = textBox3.Text;
            db.Номер.Add(номер);
            db.SaveChanges();
            MessageBox.Show("Запись добавлена!");
            dataGridView1.DataSource = db.Номер.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HotelEntities db = new HotelEntities();
            Номер номер = db.Номер.Find(Convert.ToInt32(dataGridView1.CurrentRow.Cells["Код_номера"].Value));
            номер.Вместимость = textBox1.Text;
            номер.Стоимость = Convert.ToInt32(textBox2.Text);
            номер.Статус = textBox3.Text;
            db.SaveChanges();
            MessageBox.Show("Запись обновлена!");
            dataGridView1.DataSource = db.Номер.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HotelEntities db = new HotelEntities();
            Номер номер = db.Номер.Find(Convert.ToInt32(dataGridView1.CurrentRow.Cells["Код_номера"].Value));
            if (номер != null)
            {
                db.Номер.Remove(номер);
            }
            db.SaveChanges();
            dataGridView1.DataSource = db.Номер.ToList();
            MessageBox.Show("Запись удалена!");
        }
    }
}
