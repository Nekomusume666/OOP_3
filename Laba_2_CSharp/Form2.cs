using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_2_CSharp
{
    public partial class Form2 : Form
    {
        InternetShop obj; //Объект, передаваемый форме для изменения полей

        /// <summary>
        /// Конструктор формы
        /// </summary>
        /// <param name="internetShop">Объект, передаваемый форме для изменения полей</param>
        public Form2(InternetShop internetShop)
        {
            obj = internetShop;
            InitializeComponent();
        }

        /// <summary>
        /// Кнопка "Создать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            CheckingEmptyFields();

            obj.Adress = textBox1.Text;
            obj.Name = textBox2.Text;
            obj.Purchases = Convert.ToInt32(textBox3.Text);
            obj.Guests = Convert.ToInt32(textBox4.Text);
            obj.Clients = Convert.ToInt32(textBox5.Text);
            obj.Earnings = Convert.ToDecimal(textBox6.Text);
            obj.Reviews = Convert.ToDouble(textBox7.Text);
            
            this.Close();
        }

        /// <summary>
        /// Проверка на ввод пустых полей
        /// </summary>
        private void CheckingEmptyFields()
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = obj.Adress;
            }
            if (textBox2.Text == "")
            {
                textBox2.Text = obj.Name;
            }
            if (textBox3.Text == "")
            {
                textBox3.Text = obj.Purchases.ToString();
            }
            if (textBox4.Text == "")
            {
                textBox4.Text = obj.Guests.ToString();
            }
            if (textBox5.Text == "")
            {
                textBox5.Text = obj.Clients.ToString();
            }
            if (textBox6.Text == "")
            {
                textBox6.Text = obj.Earnings.ToString();
            }
            if (textBox7.Text == "")
            {
                textBox7.Text = obj.Reviews.ToString();
            }
        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            
            obj.Deleted = true;
            Close();
        }
    }
}
