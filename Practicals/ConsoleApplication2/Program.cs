using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pattern1();
            Pattern2();
            Pattern3();
            Pattern4();
        }
        static void Pattern1()
        {
            int i, j;
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            
        }
        static void Pattern2()
        {
            int i, j;
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void Pattern3()
        {
            int i, j;
            for (i = 5; i>0; i--)
            {
                for (j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void Pattern4()
        {
            int i, j;
            for (i = 0; i <= 5; i++)
            {
                for (j = 0; j <= 5; j++)
                {
                    Console.Write(" ");
                    for(k=0;k<2*i-1;k=0)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
    }
}
