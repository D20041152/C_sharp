using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace laba_3
{
 delegate KeyValuePair<TKey, TValue> GenerateElement<TKey, TValue> (int j);
    internal class TestCollections<TKey, TValue>
    {
        public TestCollections(int count, GenerateElement<TKey, TValue> generator)
        {
            this.generator = generator;

            for(int i = 0; i < count; i++)
            {
                KeyValuePair<TKey, TValue> pair = generator(i);
                listKeys.Add(pair.Key);
                stringList.Add(pair.Value.ToString());    
                dictKey.Add(pair.Key, pair.Value);
                dictStr.Add(pair.Key.ToString(), pair.Value);
            }
        }

        public void searchListKeys()
        {
            var first = listKeys[0];
            var middle = listKeys[listKeys.Count/2];
            var end = listKeys[listKeys.Count-1];
            var nonExist = generator(listKeys.Count + 1).Key;

            Stopwatch sw = new Stopwatch();
            sw.Start();
            listKeys.Contains(first);
            sw.Stop();
            Console.WriteLine($"Первый элемент listKeys: {sw.ElapsedTicks}");
            Console.WriteLine();

            sw.Start ();
            listKeys.Contains(middle);
            sw.Stop ();
            Console.WriteLine($"Центральный элемент: {sw.ElapsedTicks}");
            Console.WriteLine ();

            sw.Start ();
            listKeys.Contains(end);
            sw.Stop ();
            Console.WriteLine($"Последний элемент: {sw.ElapsedTicks}");
            Console.WriteLine ();

            sw.Start();
            listKeys.Contains(nonExist);
            sw.Stop ();
            Console.WriteLine($"Несуществующий элемент: {sw.ElapsedTicks}");
            Console.WriteLine($"Несуществующий элемент: {sw.Elapsed}");
            Console.WriteLine ();
        }

        public void searchStringList()
        {
            var first = stringList[0];
            var middle = stringList[stringList.Count / 2];
            var end = stringList[stringList.Count - 1];
            var nonExist = generator(stringList.Count + 1).Key;

            Stopwatch sw = new Stopwatch();
            sw.Start();
            stringList.Contains(first);
            sw.Stop();
            Console.WriteLine($"Первый элемент listKeys: {sw.ElapsedTicks}");
            Console.WriteLine();

            sw.Start();
            stringList.Contains(middle);
            sw.Stop();
            Console.WriteLine($"Центральный элемент: {sw.ElapsedTicks}");
            Console.WriteLine();

            sw.Start();
            stringList.Contains(end);
            sw.Stop();
            Console.WriteLine($"Последний элемент: {sw.ElapsedTicks}");
            Console.WriteLine();

            sw.Start();
            stringList.Contains(nonExist.ToString());
            sw.Stop();
            Console.WriteLine($"Несуществующий элемент: {sw.ElapsedTicks}");
            Console.WriteLine($"Несуществующий элемент: {sw.Elapsed}");
            Console.WriteLine();
        }

        public void searchdictKey()
        {
            var first = listKeys[0];
            var middle = listKeys[stringList.Count / 2];
            var end = listKeys[stringList.Count - 1];
            var nonExist = generator(stringList.Count + 1).Key;

            Stopwatch sw = new Stopwatch();
            sw.Start();
            dictKey.ContainsKey(first);
            sw.Stop();
            Console.WriteLine($"Первый элемент: {sw.ElapsedTicks}");
            Console.WriteLine();

            sw.Start();
            dictKey.ContainsKey(middle);
            sw.Stop();
            Console.WriteLine($"Центральный элемент: {sw.ElapsedTicks}");
            Console.WriteLine();

            sw.Start();
            dictKey.ContainsKey(end);
            sw.Stop();
            Console.WriteLine($"Последний элемент: {sw.ElapsedTicks}");
            Console.WriteLine();

            sw.Start();
            dictKey.ContainsKey(nonExist);
            sw.Stop();
            Console.WriteLine($"Несущуствующий элемент: {sw.ElapsedTicks}");
            Console.WriteLine($"Несуществующий элемент: {sw.Elapsed}");

        }

        public void searchDictStr()
        {
            var first = stringList[0];
            var middle = stringList[stringList.Count / 2];
            var end = stringList[stringList.Count - 1];
            var nonExist = generator(stringList.Count + 1).Key;

            Stopwatch sw = new Stopwatch();
            sw.Start();
            dictStr.ContainsKey(first);
            sw.Stop();
            Console.WriteLine($"Первый элемент: {sw.ElapsedTicks}");
            Console.WriteLine();

            sw.Start();
            dictStr.ContainsKey(middle);
            sw.Stop();
            Console.WriteLine($"Центральный элемент: {sw.ElapsedTicks}");
            Console.WriteLine();

            sw.Start();
            dictStr.ContainsKey(end);
            sw.Stop();
            Console.WriteLine($"Последний элемент: {sw.ElapsedTicks}");
            Console.WriteLine();

            sw.Start();
            dictStr.ContainsKey(nonExist.ToString());
            sw.Stop();
            Console.WriteLine($"Несуществующий элемент: {sw.ElapsedTicks}");
            Console.WriteLine($"Несуществующий элемент: {sw.Elapsed}");
            Console.WriteLine();
        }


        private List<TKey> listKeys = new List<TKey>();   
        private List<string> stringList = new List<string>();
        private Dictionary<TKey, TValue> dictKey = new Dictionary<TKey, TValue>();
        private Dictionary<string, TValue> dictStr = new Dictionary<string, TValue>();
        private GenerateElement<TKey, TValue> generator;

    }
}
