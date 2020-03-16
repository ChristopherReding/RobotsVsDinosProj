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
        public int attackPower;        
        

        //constructor
        public Weapon(string weapon, int attackPower)
        {
            this.weapon = weapon;
            this.attackPower = attackPower;                       
        }
    }
}
