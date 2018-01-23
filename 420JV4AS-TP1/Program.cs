// Nom ici

using System;

namespace _420JV4AS_TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Question1();
            //Question2a("HelloWorld");
            //Question2a("EggsBacon");
            //Question2b("HelloWorld", 'a');
            //Question2b("HelloWorld", 'e');
            //Question2b("HelloWorld", 'o');
            //Question2c("tacocat");
            //Question2c("nyancat");
            //Question3a(4, 20);
            //Question3a(6, 8);
            //Question3a(7, 8);
            //Question3b(7);
            //Question3b(420);
            //Question3b(1);
            //Question3c(100);
            //Question3c(1000);
            //Question4a(4);
            //Question4a(8);
            //Question4b(4);
            //Question4b(8);
            //Question4c(8);
            //Question4c(32);
            Console.Read();
        }

        static void Question1()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void Question2a(string s)
        {
            Console.WriteLine(s);
        }

        static void Question2b(string s, char c)
        {
            Console.WriteLine(0);
        }

        static void Question2c(string s)
        {
            Console.WriteLine(false);
        }

        static void Question3a(int n, int m)
        {
            Console.WriteLine(1);
        }

        static void Question3b(int n)
        {
            Console.WriteLine(false);
        }

        static void Question3c(int n)
        {
            Console.WriteLine(n);
        }

        static void Question4a(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(". ");
                }
                Console.WriteLine();
            }
        }

        static void Question4b(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(". ");
                }
                Console.WriteLine();
            }
        }

        static void Question4c(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(". ");
                }
                Console.WriteLine();
            }
        }
    }
}
