﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using QuickDate.Classes;

[assembly: InternalsVisibleTo("QuickTest")]
namespace QuickDate
{
    public class Program
    {
        static void Main(string[] args)
        {
            Triangle.ExecuteProgram();
            Console.ReadKey();
        }
    }
}

   
