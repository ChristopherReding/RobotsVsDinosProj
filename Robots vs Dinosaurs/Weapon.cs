using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    class Weapon
    {
        //member variable
        public string weapon;
        public int attackPower; //amt of damage attack will do
        public int powerDrain; //power cost for attack

        //constructor
        public Weapon(string weapon, int attackPower, int powerDrain)
        {
            this.weapon = weapon;
            this.attackPower = attackPower;
            this.powerDrain = powerDrain;
        }
    }
}
