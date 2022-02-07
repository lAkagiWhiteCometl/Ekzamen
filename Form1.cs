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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "inspector" && textBox2.Text == "inspector")//Условие, при выполнении которого будет происходить вход
            {
                Form2 form2 = new Form2();
                this.Hide();
                form2.Show();
            }
            else if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Введите логин и пароль!");
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль, попробуйте ещё раз.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
