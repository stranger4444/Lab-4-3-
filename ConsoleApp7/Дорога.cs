﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Дорога
    {
        public double Довжина { get; set; }
        public double Ширина { get; set; }
        public int КількістьСмуг { get; set; }
        public int РівеньТрафіку { get; set; }

        public Дорога(double довжина, double ширина, int кількістьСмуг)
        {
            Довжина = довжина;
            Ширина = ширина;
            КількістьСмуг = кількістьСмуг;
            РівеньТрафіку = 0;
        }
    }
}
