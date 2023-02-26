﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.OOP.Polimorphism
{
    public class Developer : Employee
    {
        public int FeaturesImplementdCount { get; set; }
      
        public Developer(int featuresImplementdCount)
        {
            FeaturesImplementdCount = featuresImplementdCount;
        }

        public new int CalculateSalary()
        {
           return BaseSalary + (FeaturesImplementdCount*1000) ;
        }


          

    }
}