﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double f)
        {
            var result = (f - 32) / 1.8;
            return result;
        }
        public static double CelsiusToFahrenheit(double c)
        {
            var result = (c * 9) / 5 + 32;
            return result;
        }

    
    
    
    
    
    
    }
}
