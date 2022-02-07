using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ekzamen2
{
    public partial class Form2 : Form
    {
        Model1 db = new Model1();
        public Form2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();//Инициализация выхода
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Vodila vd = (Vodila)vodilaBindingSource.Current;//Показываем диалоговое окно с кнопками Да и Нет
            DialogResult dr = MessageBox.Show("Вы действительно хотите удалить запись в таблице? - " + vd.ID.ToString(), "Удаление записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)//Если пользователь нажал кнопку «Да», то удаляем данные из БД
            {
                //Удаление записи из БД
                db.Vodila.Remove(vd);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.db = db;
            DialogResult rd = frm3.ShowDialog();
            if (rd == DialogResult.OK)//Если данные были добавлены к БД, то обновляем содержание промежуточного объекта.
            { 
                vodilaBindingSource.DataSource = db.Vodila.ToList();
                Update();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            vodilaBindingSource.DataSource = db.Vodila.ToList();
        }
    }
}
