using System;
using System.Collections;
using static System.Console;
namespace Exercise4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SortedList dic = new SortedList();
            string word;
            while (true)
            {
                WriteLine("Enter english word with its translation: ");
                dic.Add(ReadLine(), ReadLine());
                Clear();
                WriteLine("****************************************");
                foreach (var item in dic.Keys)
                {
                    WriteLine(dic[item] + " = " + item);
                }
                WriteLine("****************************************");
            }

        }
    }
}