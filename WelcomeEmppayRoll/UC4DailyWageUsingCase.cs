﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeEmppayRoll
{
    internal class UC4DailyWageUsingCase
    {
      const int  EMP_RATE_ER_HOUR = 20;

        public static void DailyWageUsingCase()
        {

            

            int empHour = 0;
            int empWage = 0;
            Random random = new Random();

            int empcheck = random.Next(0, 2);
            switch (empcheck)
            {
                case 0:
                    empHour = 8;
                    break;
                case 1:
                    empHour = 4;
                    break;
                default:
                    empHour = 0;
                    break;
            }

            empWage = empHour * EMP_RATE_ER_HOUR;
            Console.WriteLine(" Emp Wage is " + empWage);
        }
        
    }
}
