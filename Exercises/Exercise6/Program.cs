using System;
using System.Collections;
using static System.Console;
using System.Threading;
using System.Globalization;
namespace Exercise6
{
    public abstract class Program
    {
        public static void Main(string[] args)
        {
            MyString str = new MyString();
            str.StrSet("amir");
            str.WriteIt();
            WriteLine(str.Reverse());
            ReadKey();
        }
    }
    public class MyString
    {
        private string _str;
        private int _len;

        public MyString(){} // constructor
        
        public MyString(string vacant) // overloading the constructor
        {
            _str = vacant;
            _len = _str.Length;
        }
        
        public void StrSet (string vacant)
        {
            _str = vacant;
            _len = _str.Length;
        }

        public string StrGet()
        {
            return _str;
        }

        public void WriteIt()
        {
            WriteLine("str: {0} \t len: {1}" , _str , _len);
        }

        public string Reverse()
        {   
            char[] words = _str.ToCharArray();
            char[] wordsLen = new char[_len];

            int i = 0;
            int j = _len - 1;

            for (i = 0; i < _len; i++)
            {
                wordsLen[i] = words[j];
                j--;
            }
            
            return String.Join("", wordsLen);
        }
    }
}