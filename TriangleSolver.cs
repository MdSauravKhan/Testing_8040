using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_8040
{
    public  class TriangleSolver
    {
        

        public int Analyze(int x,int y,int z)
        {

            // inequality theorem to check the form of triangle.

            if (x + y > z && y + z > x && z + x > y)
            {
                Console.WriteLine("These Dimentions can form a Triangle !!!");

                //checking he types of tringle by input dimentions

                if (x == y && y == z && z == x)
                {
                    Console.WriteLine("Triangle is Equilateral.");
                    return 0;

                }
                else if (x == y || y == z || z == x)
                {
                    Console.WriteLine("Triange is Isosceles.");
                    return 1;
                }
                else

                {

                    Console.WriteLine("Triangle is Scalene");
                    return 2;

                }
            }
            else
                Console.WriteLine("Unable to form a Triangle !!!");
            return 3;          
            //Nothing
            
        }
    }
}
