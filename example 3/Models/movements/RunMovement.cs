using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.example_3.Models.movements
{
    public class RunMovement : Movoment
    {
        public override void Move()
        {
            Console.WriteLine("Бежим");
        }
    }
}
