﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Console_Application
{
    class Program
    {        
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i != 0)
                {
                    if (i % 3 == 0 && i != 15)
                        Console.WriteLine("Modern");
                    if (i % 5 == 0 && i != 15)
                        Console.WriteLine("Medical");
                    if (i % 3 == 0 && i % 5 == 0)
                        Console.WriteLine("ModernMedical");
                    if (i % 3 != 0 && i % 5 != 0)
                        Console.WriteLine(i);
                }
            }
            Console.Read();
        }        
    }
}
