using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    public interface Iconverter
    {
        string From { get; }
        string To { get; }
        double Convert(double value);
    }
}
