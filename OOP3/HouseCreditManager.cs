﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class HouseCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Credit payment plan calculaed for house.");
        }
    }
}
