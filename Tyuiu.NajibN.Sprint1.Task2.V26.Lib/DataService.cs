﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NajibN.Sprint1.Task2.V26.Lib
{
    public class DataService : ISprint1Task2V26
    {
        public int CalculateMinutesSinceStart(int hour, int min)
        {
            return (hour * 60) + min;
        }
        
            
        
    }
}
