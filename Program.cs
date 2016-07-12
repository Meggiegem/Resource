using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{//Homework Assignment #3
    class Program
    {
            static void Main(string[] args)
            {
                TimeSpan t = TimeSpan.FromSeconds(259200);
                Console.WriteLine(t.Days);
                Console.WriteLine(t.Hours);
                Console.WriteLine(t.Minutes);
                Console.WriteLine(t.Seconds);
                Console.WriteLine(t.ToString());
            }
        }
    }
  
