using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderSample
{
    public class House
    {
        public int Door { get; set; }
        public int Windows { get; set; }
        public string Wall { get; set; }
        public string Foundation { get; set; }
        public string Roof { get; set; }

        public void PrintHouseInfo()
        {
            Console.WriteLine($"Door : {this.Door}");
            Console.WriteLine($"Windows : {this.Windows}");
            Console.WriteLine($"Wall : {this.Wall}");
            Console.WriteLine($"Foundation : {this.Foundation}");
            Console.WriteLine($"Roof : {this.Roof}");
        }
    }
}
