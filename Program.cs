using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_part3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First 10 numbers in the Fibonacci sequence:");

            int n = 10, f1 = 0, f2 = 1, f3;

           
                   
            for (int i = 0; i < n; i++)
            {
                f3 = f1 + f2;
                Console.WriteLine(f1);
                f1 = f2;
                f2 = f3;
                Console.ReadKey();
            }
                }
                
            }
        }
    

   
