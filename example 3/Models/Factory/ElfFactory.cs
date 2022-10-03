using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pattern.example_3.Models.movements;

namespace Pattern.example_3.Models.Factory
{
    public class ElfFactory : HeroFactory
    {
        public override Movoment CreateMovement()
        {
            return new FlyMovement();
        }

        public override Weapon CreateWeapon()
        {
            return new Arbalet();
        }
    }
}
