using System;

namespace MyDictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDict = new MyDictionary<int, string>();
            myDict.Add(123456, "Student1");
            myDict.Add(654321, "Student2");
            foreach(int key in myDict.Keys)
            {
                Console.WriteLine(key);
            }
        }
    }
}
