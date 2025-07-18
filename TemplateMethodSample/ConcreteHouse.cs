using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodSample
{
    public class ConcreteHouse : HouseTemplate
    {
        protected override void BuildPillars()
        {
            Console.WriteLine("Building Concrete Pillars with Cement and Sand");
        }
        protected override void BuildWalls()
        {
            Console.WriteLine("Building Concrete Walls");
        }
        protected override void BuildWindows()
        {
            Console.WriteLine("Building Concrete Windows");
        }
    }
}
