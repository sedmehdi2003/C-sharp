// this exercise is about jagged arrays .
using System;
using static System.Console;
namespace Exercise3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            char[][] name = new char[6][];
            name[0] = new char[3];
            name[1] = new char[4];
            name[2] = new char[5];
            name[3] = new char[6];
            name[4] = new char[7];
            name[5] = new char[8];

            for (int i = 0; i < 6; i++)
            {
                for (int j= 0; j < name[i].Length; j++)
                {
                    Write("Enter characters for row {0} and columns {1}: ",i+1 , j + 1);
                    name[i][j] = Convert.ToChar(ReadLine());
                }
                Clear();
            }
            
            for (int i = 0; i < 6; i++)
            {
                foreach (var item in name[i])
                {
                    Write(item);
                    
                }
                WriteLine();
            }
            
        }
    }
}