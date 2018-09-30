using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3unit
{
    class CheckTriangle
    {
        public bool IsTriangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Passed argument is wrong!");
            return a + b > c && b + c > a && c + a > b ? true : false;
        }
    }
}
