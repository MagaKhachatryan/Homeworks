﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClient
{
    class Program
    {
        static void Main(string[] args)
        {
            TCP client = new TCP();
            client.SendResult();
            Console.ReadLine();
        }
    }
}
