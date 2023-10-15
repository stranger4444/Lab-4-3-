using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Транспортний_засіб : IDriveable
    {
        public string Тип { get; set; }
        public double Швидкість { get; set; }
        public double Розмір { get; set; }

        public Транспортний_засіб(string тип, double швидкість, double розмір)
        {
            Тип = тип;
            Швидкість = швидкість;
            Розмір = розмір;
        }

        public void Рухатися()
        {
            Console.WriteLine($"Транспортний засіб типу {Тип} рухається зі швидкістю {Швидкість} км/год.");
        }

        public void Зупинитися()
        {
            Console.WriteLine($"Транспортний засіб типу {Тип} зупинився.");
        }
    }
}
