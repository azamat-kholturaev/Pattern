using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.example_3.Models.Factory
{
    public abstract class HeroFactory
    {
        public abstract Movoment CreateMovement();
        public abstract Weapon CreateWeapon();


    }
}
