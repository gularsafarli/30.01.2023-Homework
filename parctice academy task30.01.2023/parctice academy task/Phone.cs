using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Xml.Linq;

namespace parctice_academy_task
{
    internal class Phone:Product
    {
        public Phone(string name, double price) : base(name, price)
        {

        }
        public int Camera;

        public override void ShowInfo()
        {
            Console.WriteLine($"Name: {Name} - Price: {Price} - Camera: {Camera}");
        }
    }
}
