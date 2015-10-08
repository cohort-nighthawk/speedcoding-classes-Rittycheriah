using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedCodingClasses
{
    public class Car : Vehicle
    {
        public Car()
        {
            numOWheels = 4;
        }

        public override string Horn()
        {
            return "HOOOOOOOONNKKKKKKKKKKKKKK";
        }
    }
}
