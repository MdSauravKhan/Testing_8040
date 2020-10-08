using System;

namespace Assignment_8040
{
    class Triangle
    {
        
        public static void Main(string[] args)
        {


        TriangleSolver tri = new TriangleSolver();
             
            
        Console.WriteLine("Press 1 or 2 to choose menu!!!");
            Console.WriteLine("1. Enter triangle dimensions");
            Console.WriteLine("2. Exit");

            
            int menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    Console.WriteLine("Enter first dimension:");
                    int first = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter second dimension:");
                    int second = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter third dimension:");
                    int third = int.Parse(Console.ReadLine());

                    tri.Analyze(first, second, third);
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("If you want to analyze again");
                    Main(new string[0]);
                    break;

                case 2:
                    break;
            }

           
        }
    }
}
