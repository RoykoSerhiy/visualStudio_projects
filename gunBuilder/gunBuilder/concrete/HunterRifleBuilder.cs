using gunBuilder.Abstract;
using gunBuilder.parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gunBuilder.concrete
{
    class HunterRifleBuilder : GunBuilder
    {
        public override void SetBarrel()
        {
            Gun.Barrel = new HunterBarrel();
        }
        public override void SetPriklad()
        {
            Gun.Priklad = new HunterPriklad();
        }
        public override void SetSight()
        {
            Gun.Sight = new ColimatorSight(); 
        }
        public override void SetTrigger()
        {
            Gun.Trigger = new SoftTrigger();
        }
        public override void SetMagazine()
        {
            Gun.Magazin = new SmallMagazine();
        }
    }
}
