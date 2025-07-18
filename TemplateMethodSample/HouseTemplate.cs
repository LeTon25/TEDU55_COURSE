﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodSample
{
    public abstract class HouseTemplate
    {
        // Template Method defines the sequence for building a house
        public void BuildHouse()
        {
            //Define the Steps to Build a House
            BuildFoundation(); //Step1
            BuildPillars(); //Step2
            BuildWalls(); //Step3
            BuildWindows(); //Step4
            BuildRoof(); // Step 5
            Console.WriteLine("House is Built");
        }

        // Default implementation 
        protected virtual void BuildFoundation()
        {
            Console.WriteLine("Building foundation with cement, iron rods and sand");
        }
        protected virtual void BuildRoof()
        {
            Console.WriteLine("Building roof");
        }
        // Methods to be implemented by subclasses
        protected abstract void BuildPillars();
        protected abstract void BuildWalls();
        protected abstract void BuildWindows();
    }

}
