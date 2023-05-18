using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JetFinal
{
     class Player :Plane
    {
        int ammo;
        bool GoLeft, GoRight;


        public Player()
        {
            attack_direction = "up";
            health = 100;
            speed = 20;
            attack_damage = 100;

        }

        public void getLeft()
        {


        }
    }
}
