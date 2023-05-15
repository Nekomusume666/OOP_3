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
    public partial class Form5 : Form
    {
        InternetShop obj; //Объект, передаваемый форме для изменения полей

        /// <summary>
        /// Конструктор
        /// </summary>
        public Form5(InternetShop internetShop)
        {
            InitializeComponent();
            obj = internetShop;
        }

        /// <summary>
        /// Кнопка "Выход"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Кнопка "Применить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            string value = textBox1.Text;

            if (radioButton1.Checked)
            {
                obj.Adress = value;
            }
            else if (radioButton2.Checked)
            {
                obj.Name = value;
            }
            else if (radioButton3.Checked)
            {
                obj.Purchases = Convert.ToInt32(value);
            }
            else if (radioButton4.Checked)
            {
                obj.Guests = Convert.ToInt32(value);
            }
            else if (radioButton5.Checked)
            {
                obj.Clients = Convert.ToInt32(value);
            }
            else if (radioButton6.Checked)
            {
                obj.Earnings = Convert.ToDecimal(value);
            }
            else if (radioButton7.Checked)
            {
                obj.Reviews = Convert.ToDouble(value);
            }

            this.Close();
        }
    }
}
