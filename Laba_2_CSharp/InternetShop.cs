using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2_CSharp
{
    public class InternetShop
    {
        private string _adress;     //Адрес
        private string _name;       //Название магазина
        private int _purchases;     //Количество покупок
        private int _guests;        //Количество гостей
        private int _clients;       //Количество покупателей
        private decimal _earnings;  //Выручка
        private double _reviews;    //Отзывы
        private int _number;        //Номер объекта
        public static int counter;//Счетчик объектов

        

        private bool _deleted;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public InternetShop()
        {
            _adress = "unknown" + counter;
            _name = "unknown";
            _purchases = 0;
            _guests = 0;
            _clients = 0;
            _earnings = 0;
            _reviews = 0;
            counter++;
            _deleted = false;
        }


        /// <summary>
        /// Геттеры и сеттеры
        /// </summary>
        public string Adress
        {
            get { return _adress; }
            set { _adress = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Purchases
        {
            get { return _purchases; }
            set { _purchases = value; }
        }
        public int Guests
        {
            get { return _guests; }
            set { _guests = value; }
        }
        public int Clients
        {
            get { return _clients; }
            set { _clients = value; }
        }
        public decimal Earnings
        {
            get { return _earnings; }
            set { _earnings = value; }
        }
        public double Reviews
        {
            get { return _reviews; }
            set { _reviews = value; }
        }
        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }
        public int Counter
        {
            get { return counter; }
            set { counter = value; }
        }
        public bool Deleted
        {
            get { return _deleted; }
            set { _deleted = value; }
        }

        /// <summary>
        /// Переопределённый метод .ToString()
        /// </summary>
        /// <returns>Строку, содержащую все поля класса</returns>
        public override string ToString()
        {
            return $"Информация об объекте под номером {_number}:\n" +
                $"Адрес: {_adress};\n" +
                $"Имя: {_name};\n" +
                $"Покупки: {_purchases};\n" +
                $"Гости: {_guests};\n" +
                $"Клиенты: {_clients};\n" +
                $"Выручка: {_earnings};\n" +
                $"Отзывы: {_reviews}.\n";
        }

        /// <summary>
        /// Вывод непосредственно обращаясь к полю
        /// </summary>
        /// <param name="field">Имя поля</param>
        public string ViewField(string field)
        {
            switch (field)
            {
                case "Адрес":
                    return "Адрес: " + _adress;
                case "Имя":
                    return "Имя: " + _name;
                case "Покупки":
                    return "Покупки: " + _purchases.ToString();
                case "Гости":
                    return "Гости: " + _guests.ToString();
                case "Клиенты":
                    return "Клиенты: " + _clients.ToString();
                case "Выручка":
                    return "Выручка: " + _earnings.ToString();
                case "Отзывы":
                    return "Отзывы: " + _reviews.ToString();
                default:
                    return "";
            }
        }

        /// <summary>
        /// Вывод в 16 системе счисления
        /// </summary>
        /// <param name="number">число</param>
        /// <param name="fractionalDigits">дробные цифры</param>
        /// <returns></returns>
        private static string Base16(decimal number, int fractionalDigits)
        {
            return Base(number, fractionalDigits, new char[]{
        '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
        'A', 'B', 'C', 'D', 'E', 'F' });
        }
        /// <summary>
        /// Перевод в 16 систему счисления
        /// </summary>
        /// <param name="number">число</param>
        /// <param name="fractionalDigits">дробные цифры</param>
        /// <param name="characters">символ</param>
        /// <returns></returns>
        private static string Base(decimal number, int fractionalDigits, params char[] characters)
        {
            int radix = characters.Length;
            StringBuilder sb = new StringBuilder();

            // The 'whole' part of the number.
            long whole = (long)Math.Floor(number);
            while (whole > 0)
            {
                sb.Insert(0, characters[whole % radix]);
                whole = whole / radix;
            }

            // The fractional part of the number.
            double remainder = (double)number % 1;
            if (remainder > Double.Epsilon || remainder < -Double.Epsilon)
            {
                sb.Append(',');

                double nv;
                for (int i = 0; i < fractionalDigits; i++)
                {
                    nv = remainder * radix;
                    if (remainder < Double.Epsilon && remainder > -Double.Epsilon)
                        break;
                    sb.Append(characters[(int)Math.Floor(nv)]);
                    remainder = nv % 1;
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// Вывод в 16 системе счисления
        /// </summary>
        /// <param name="field">Имя поля</param>
        public string ViewIn16(string field)
        {
            String message = "0x";

            switch (field)
            {
                case "Покупки":
                    if (_purchases == 0)
                    {
                        message += "0";
                    }
                    return message += Base16(_purchases, 10);
                case "Гости":
                    if (_guests == 0)
                    {
                        message += "0";
                    }
                    return message += Base16(_guests, 10);
                case "Клиенты":
                    if (_clients == 0)
                    {
                        message += "0";
                    }
                    return message += Base16(_clients, 10);
                case "Выручка":
                    if (_earnings == 0)
                    {
                        message += "0";
                    }
                    return message += Base16(_earnings, 10);
                case "Отзывы":
                    if (_reviews == 0)
                    {
                        message += "0";
                    }
                    return message += Base16((decimal)_reviews, 10);
                default:
                    return "";
            }
        }
    }
}
