﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodSample
{
    public class WoodenHouse : HouseTemplate
    {
        protected override void BuildPillars()
        {
            Console.WriteLine("Building wood Pillars with wood coating");
        }
        protected override void BuildWalls()
        {
            Console.WriteLine("Building Wood Walls");
        }
        protected override void BuildWindows()
        {
            Console.WriteLine("Building Wood Windows");
        }
    }
}
