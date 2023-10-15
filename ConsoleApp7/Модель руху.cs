using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Модель_руху
    {
        public static void РухТранспорту(Дорога дорога, Транспортний_засіб транспорт)
        {
            // Імітуємо зміну руху транспорту залежно від рівня трафіку на дорозі та інших чинників
            if (дорога.РівеньТрафіку > 50)
            {
                транспорт.Зупинитися();
            }
            else
            {
                транспорт.Рухатися();
            }
        }
    }
}