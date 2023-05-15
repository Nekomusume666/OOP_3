using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2_CSharp
{

    class MyDictionary
    {
        static Dictionary<string, InternetShop> internetDict = new Dictionary<string, InternetShop>();

        public static event EventHandler objectAllClear;

        static public void Add(InternetShop internetShop)
        {
            internetDict.Add(internetShop.Adress, internetShop);
        }

        static public void Clear()
        {
            internetDict.Clear();
            InternetShop.counter = 0;

            objectAllClear?.Invoke(null, null);
            
        }

        static public int Count()
        {
            return internetDict.Count();
        }

        public static Dictionary<string, InternetShop> InternetDict()
        {
            return internetDict;
        }

        public static Dictionary<string, InternetShop> Remove(string selected)
        {

            internetDict.Remove(selected);
            InternetShop.counter--;
            return internetDict;
        }

        public static void RenameKey(string fromKey, string toKey)
        {
            InternetShop value = internetDict[fromKey];
            internetDict.Remove(fromKey);
            internetDict[toKey] = value;
        }

    }

}
