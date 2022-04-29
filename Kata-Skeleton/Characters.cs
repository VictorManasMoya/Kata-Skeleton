using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_Skeleton
{
    internal class Characters
    {
        public int Health { get; internal set; } = 1000;

        internal bool IsAlive()
        {
            return true;
        }

        internal bool DealDamage(Characters rival)
        {
            //rival.Health - 50;
            if (this.GetHashCode() == rival.GetHashCode())
            {
                return false;
            }

            return true;
        }

        internal bool Heal(Characters rival)
        {
            if (this.GetHashCode() == rival.GetHashCode())
            {
                return false;
            }

            return true;
        }

        internal bool CanBeHealed()
        {

            return (Health > 0) && (Health < 1000);     
        }
    }
}
