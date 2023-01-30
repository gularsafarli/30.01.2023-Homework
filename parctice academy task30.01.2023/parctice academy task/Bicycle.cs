using System;
using System.Collections.Generic;
using System.Text;

namespace parctice_academy_task
{
    internal class Bicycle
    {
        public string Brand;
        public string Model;
        public double Millage;

        public void Drive(double km)
        {
            Millage += km;
        }
    }
}
