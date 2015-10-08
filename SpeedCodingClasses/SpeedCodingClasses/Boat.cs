using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedCodingClasses
{
    public class Boat : Vehicle
    {
        public Boat()
        {
            numOWheels = 0;
        }

        public override string Horn()
        {
            return "Boats Don't Honk.... I think";
        }
    }
}
