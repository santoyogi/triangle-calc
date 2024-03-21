using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangleCalculator
{
    class triangleStats
    {
        double _sideA, _sideB;

        public triangleStats(double sideA, double sideB)
        {
            _sideA = sideA;
            _sideB = sideB;
        }

        public double GetArea()
        {
            return .5 * _sideA * _sideB;
        }

        public double GetHypotenuse()
        {
            double hype = Math.Sqrt(Math.Pow(_sideA, 2) + Math.Pow(_sideB, 2));
            return hype;
        }
    }
}

