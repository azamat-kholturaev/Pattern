using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    public class Car : Vehicle
    {
        public override void Move() => Console.WriteLine("Машина едет");
    }
}
