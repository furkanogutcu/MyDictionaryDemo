using System;
using System.Collections.Generic;

namespace MyDictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDict = new MyDictionary<int, string>();
            myDict.Add(123, "Deneme");
            myDict.Add(456, "Deneme2");
            foreach(int key in myDict.Keys)
            {
                Console.WriteLine(key);
            }
        }
    }
}
