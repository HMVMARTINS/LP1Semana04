using System;

namespace Special
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert n-th number of the special sequence:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(GetSpecial(n));
        }

        private static int GetSpecial(int n)
        { 
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;

            return 2 * GetSpecial(n - 1) + GetSpecial(n - 2);
        }
    }
}
