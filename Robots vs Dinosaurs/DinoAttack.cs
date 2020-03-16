using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    class DinoAttack
    {
        //member variables
        public string attackMethod;
        public int attackPower;

        //constructor
        public DinoAttack(string attackMethod, int attackPower)
        {
            this.attackMethod = attackMethod;
            this.attackPower = attackPower;
        }
    }
}
