using System;
namespace inlamning4._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur bred vill du att triangeln ska vara? Svara med en valfri siffra.");
            int triangleWidth = int.Parse(Console.ReadLine());

            for (int i = 1; i <= triangleWidth; i++)
            {
                for (int x = 1; x <= i; x++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();

            }
            Console.ReadKey();

        }

    }

}
