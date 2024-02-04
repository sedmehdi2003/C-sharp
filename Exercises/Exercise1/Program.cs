// this exersice is about prime numbers between 100 to 1000

namespace Exercise1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int x = 100; x < 1000; x++)
            {
                int isPrime = 0;
                for (int y = 1; y < x; y++)
                {
                    if (x % y == 0)
                        isPrime++;

                    if (isPrime == 2) break;
                }
                if (isPrime != 2)
                    Console.WriteLine(x);

                isPrime = 0;
            }
            Console.ReadKey();
        }
    }
}