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
    public partial class Form4 : Form
    {
        InternetShop obj; //Объект, передаваемый форме для изменения полей

        /// <summary>
        /// Конструктор
        /// </summary>
        public Form4(InternetShop internetShop)
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
        /// Кнопка "Покупки"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(obj.ViewIn16("Покупки"), "Вывод непосредственно обращаясь к полю",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }

        /// <summary>
        /// Кнопка "Гости"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(obj.ViewIn16("Гости"), "Вывод непосредственно обращаясь к полю",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }

        /// <summary>
        /// Кнопка "Клиенты"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(obj.ViewIn16("Клиенты"), "Вывод непосредственно обращаясь к полю",
                       MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }

        /// <summary>
        /// Кнопка "Выручка"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(obj.ViewIn16("Выручка"), "Вывод непосредственно обращаясь к полю",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }

        /// <summary>
        /// Кнопка "Отзывы"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show(obj.ViewIn16("Отзывы"), "Вывод непосредственно обращаясь к полю",
                       MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
