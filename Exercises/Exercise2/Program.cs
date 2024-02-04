// this exersice is about writing a matrice with 2D arrays
using System;
using static System.Console;

namespace Exercise2
{
public class Program
{
    public static void Main(string[] args)
    {
        Write("Enter first Number: ");
        int num1 = Convert.ToInt32(ReadLine());
        Write("Enter second Number: ");
        int num2 = Convert.ToInt32(ReadLine());
        Clear();
        Write("number of rows = {0} and columns = {1} ", num1, num2);
        WriteLine("\n\n\n\n\n\n\n");
        for (int i = 0; i < num1; i++)
        {
            Write("\t\t\t\t\t\t");
            for (int j = 0; j < num2; j++)
            {
                if (i == j)
                {
                    Write("1 ");
                }
                else
                {
                    Write("0 ");
                }
                Thread.Sleep(70);
            }
            WriteLine();
        }
        ReadKey();
    }

}
}