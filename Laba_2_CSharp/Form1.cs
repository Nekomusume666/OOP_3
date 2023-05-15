using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_2_CSharp
{
    public partial class Form1 : Form
    {
        List<InternetShop> list = new List<InternetShop>(); //Список объектов

        string fake_addr = "fake";
        InternetShop temp;


        public static void NewObjectClear(object sender, EventArgs e)
        {
            MessageBox.Show("Вы удалили все обьекты");
        }
        public static void NewObjectClear2(object sender, EventArgs e)
        {
            MessageBox.Show("Словарь пустой!");
        }

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            listView1.Items.Add("Последовательная");
            listView1.Items.Add("Случайная");
        }

        /// <summary>
        /// Вывод информации о задании
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>    
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Дополнить класс, созданный в лабораторной работе №1. Реализовать в" +
                            "классе счетчик созданных объектов, задействовать статический член класса." +
                            "Изменение и вывод информации в объектах класса организовать через GUI." +
                            "Вывести содержимое класса на экран пользователю."+
                            "Реализовать в коде лабораторной работы перехват и обработку исключений: " +
                            "IndexOutOfRangeException.", "Информация о задании" , MessageBoxButtons.OK,
                            MessageBoxIcon.Asterisk);
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
        /// Кнопка "Создать объект"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            InternetShop internetShop = new InternetShop();
            //int count = list.Count;
            MyDictionary.Add(internetShop);
            //list[count].Number = count;
            internetShop.Number = internetShop.Counter;
            Form f2 = new Form2(internetShop);
            f2.Left = this.Left + 175;
            f2.Top = this.Top + 30;
            f2.ShowDialog();

            if (internetShop.Deleted)
            {
                MyDictionary.Remove(internetShop.Adress);
                internetShop.Counter--;
                internetShop = null;
            }
            else
            {
                UpdatingDataGried(internetShop);
            }
        }

        /// <summary>
        /// Функция записывающая новый объект в таблицу
        /// </summary>
        /// <param name="internetShop">объект</param>
        private void UpdatingDataGried(InternetShop internetShop)
        {
            dataGridView1.RowCount++;

            dataGridView1.Rows[internetShop.Number - 1].Cells[0].Value = internetShop.Number;
            dataGridView1.Rows[internetShop.Number - 1].Cells[1].Value = internetShop.Adress;
            dataGridView1.Rows[internetShop.Number - 1].Cells[2].Value = internetShop.Name;
            dataGridView1.Rows[internetShop.Number - 1].Cells[3].Value = internetShop.Purchases;
            dataGridView1.Rows[internetShop.Number - 1].Cells[4].Value = internetShop.Guests;
            dataGridView1.Rows[internetShop.Number - 1].Cells[5].Value = internetShop.Clients;
            dataGridView1.Rows[internetShop.Number - 1].Cells[6].Value = internetShop.Earnings;
            dataGridView1.Rows[internetShop.Number - 1].Cells[7].Value = internetShop.Reviews;

            dataGridView1.Update();
            label2.Text = "Всего объектов: " + internetShop.Counter;
        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Вывод переопределённого метода .ToString()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            bool found = false;
            InternetShop internetShop = null;
            foreach (var obj in MyDictionary.InternetDict())
            {
                if (obj.Value.Number == (int)numericUpDown1.Value)
                {
                    MessageBox.Show(obj.ToString(), "Переопределённый метод .ToString()",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    found = true;
                    break;
                }  
            }
            if (!found)
            {
                Win32.MessageBox(0, "Ошибка, объект под таким номером не существует",
                    "Пример вызова неуправляемого кода", 0);
            }
        }

        /// <summary>
        /// Вывод непосредственно обращаясь к полю
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                InternetShop internetShop = list[(int)numericUpDown1.Value];
                Form f3 = new Form3(internetShop);
                f3.Left = this.Left + 175;
                f3.Top = this.Top + 30;
                f3.ShowDialog();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Win32.MessageBox(0, "Ошибка, объект под таким номером не существует",
                    "Пример вызова неуправляемого кода", 0);
                return;
            }
        }

        /// <summary>
        /// Вывод в 16 системе счисления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                InternetShop internetShop = list[(int)numericUpDown1.Value];
                Form f4 = new Form4(internetShop);
                f4.Left = this.Left + 175;
                f4.Top = this.Top + 30;
                f4.ShowDialog();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Win32.MessageBox(0, "Ошибка, объект под таким номером не существует",
                    "Пример вызова неуправляемого кода", 0);
                return;
            }
        }

       

        /// <summary>
        /// Изменить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                InternetShop internetShop = null;
                foreach (var item in MyDictionary.InternetDict()) {
                    if (item.Value.Number == (int)numericUpDown1.Value)
                    {
                        internetShop = item.Value;
                        break;
                    }
                }
                Form f5 = new Form5(internetShop);
                f5.Left = this.Left + 175;
                f5.Top = this.Top + 30;
                f5.ShowDialog();
                UpdatingAfterChanging();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Win32.MessageBox(0, "Ошибка, объект под таким номером не существует", 
                    "Пример вызова неуправляемого кода", 0);
                return;
            }
        }

        public class Win32
        {
            [DllImport("user32.dll", CharSet = CharSet.Auto)]
            public static extern IntPtr MessageBox(int hWnd, String text,
            String caption, uint type);
        }
        


        /// <summary>
        /// Обновление таблицы после изменения значения поля
        /// </summary>
        private void UpdatingAfterChanging()
        {
            foreach (var internetShop in MyDictionary.InternetDict())
            {
                dataGridView1.Rows[internetShop.Value.Number].Cells[0].Value = internetShop.Value.Number;
                dataGridView1.Rows[internetShop.Value.Number].Cells[1].Value = internetShop.Value.Adress;
                dataGridView1.Rows[internetShop.Value.Number].Cells[2].Value = internetShop.Value.Name;
                dataGridView1.Rows[internetShop.Value.Number].Cells[3].Value = internetShop.Value.Purchases;
                dataGridView1.Rows[internetShop.Value.Number].Cells[4].Value = internetShop.Value.Guests;
                dataGridView1.Rows[internetShop.Value.Number].Cells[5].Value = internetShop.Value.Clients;
                dataGridView1.Rows[internetShop.Value.Number].Cells[6].Value = internetShop.Value.Earnings;
                dataGridView1.Rows[internetShop.Value.Number].Cells[7].Value = internetShop.Value.Reviews;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ListViewItem lv1 = new ListViewItem();
            ListViewItem lv2 = new ListViewItem();
            lv1.Text = "Последовательная";
            lv2.Text = "Случайная";
            Random random = new Random();
            const int N = 10000;
            InternetShop[] array = new InternetShop[N];

            for (int i = 0; i < N; i++)
            {
                MyDictionary.Add(new InternetShop());
                array[i] = new InternetShop();
            }

            Stopwatch TimeArraySuccessively = new Stopwatch();
            Stopwatch TimeDictionarySuccessively = new Stopwatch();

            TimeDictionarySuccessively.Start();
            foreach (var internetShop in MyDictionary.InternetDict().ToArray())
            {
                //MyDictionary.RenameKey(internetShop.Key, fake_addr);
                temp = internetShop.Value;
            }
            TimeDictionarySuccessively.Stop();

            TimeArraySuccessively.Start();
            foreach (InternetShop internetShop in array)
            {
                internetShop.Adress = fake_addr;
                temp = internetShop;
            }
            TimeArraySuccessively.Stop();

            Stopwatch TimeArrayRandom = new Stopwatch();
            Stopwatch TimeDictionaryRandom = new Stopwatch();

            TimeDictionaryRandom.Start();
            foreach (var internetShop in MyDictionary.InternetDict())
            {
                MyDictionary.InternetDict().TryGetValue("unknown" + random.Next(0, N), out InternetShop result);
                temp = result;
            }
            TimeDictionaryRandom.Stop();

         
            TimeArrayRandom.Start();
            for (int i = 0; i < N; i++)
            {
                int index = random.Next(0, N);
                array[index].Name = fake_addr;
                temp = array[index];
            }
            TimeArrayRandom.Stop();

            MyDictionary.Clear();
            System.Array.Clear(array, 0, array.Length);
            lv1.SubItems.Add(TimeDictionarySuccessively.ElapsedTicks.ToString());
            lv1.SubItems.Add(TimeArraySuccessively.ElapsedTicks.ToString());
            lv2.SubItems.Add(TimeDictionaryRandom.ElapsedTicks.ToString());
            lv2.SubItems.Add(TimeArrayRandom.ElapsedTicks.ToString());
            listView1.Items[0] = lv1;
            listView1.Items[1] = lv2;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (InternetShop.counter != 0)
            {
                MyDictionary.objectAllClear += NewObjectClear;
                MyDictionary.Clear();
                MyDictionary.objectAllClear -= NewObjectClear;
                dataGridView1.Rows.Clear();
                dataGridView1.RowCount = 1;
                dataGridView1.Update();
            }
            else
            {
                MyDictionary.objectAllClear += NewObjectClear2;
                MyDictionary.Clear();
                MyDictionary.objectAllClear -= NewObjectClear2;
            }

            
            label3.Text = "Колво объектов:" + InternetShop.counter;
            label2.Text = "Всего объектов: " + InternetShop.counter;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Random rnd2 = new Random();
            int N = rnd2.Next(100, 200);
            for (int i = 0; i < N; i++)
            {
                InternetShop internetShop = new InternetShop();
                MyDictionary.Add(internetShop);
                internetShop.Number = internetShop.Counter;
                UpdatingDataGried(internetShop);
            }
            label3.Text = "Кол-во сгенерированных объектов: " + InternetShop.counter;
            label2.Text = "Всего объектов: " + InternetShop.counter;
        }
    }
}
