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
    public partial class Form3 : Form
    {
        InternetShop obj; //Объект, передаваемый форме для изменения полей

        /// <summary>
        /// Конструктор
        /// </summary>
        public Form3(InternetShop internetShop)
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
        /// Кнопка "Адрес"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(obj.ViewField("Адрес"), "Вывод непосредственно обращаясь к полю",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }

        /// <summary>
        /// Кнопка "Имя"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(obj.ViewField("Имя"), "Вывод непосредственно обращаясь к полю",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }

        /// <summary>
        /// Кнопка "Покупки"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(obj.ViewField("Покупки"), "Вывод непосредственно обращаясь к полю",
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
            MessageBox.Show(obj.ViewField("Гости"), "Вывод непосредственно обращаясь к полю",
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
            MessageBox.Show(obj.ViewField("Клиенты"), "Вывод непосредственно обращаясь к полю",
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
            MessageBox.Show(obj.ViewField("Выручка"), "Вывод непосредственно обращаясь к полю",
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
            MessageBox.Show(obj.ViewField("Отзывы"), "Вывод непосредственно обращаясь к полю",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }
    }
}
