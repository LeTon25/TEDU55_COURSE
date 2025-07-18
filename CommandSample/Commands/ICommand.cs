using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandSample.Commands
{
    public interface ICommand
    {
        double Execute(double value);
        double Undo(double value);
    }
}
