using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    class Dinosaur
    {
        //member variables
        public string dinoType; //dino name
        public int dinoHealth; //dino dies when this hits 0
        public int dinoEnergy; //energy will be required to attack during take turn
        public int dinoPower; //strength dino's attack

        //constructor
        public Dinosaur(string type, int health, int power)
        {
            this.dinoType = type;
            this.dinoHealth = health;
            this.dinoPower = power;
            dinoEnergy = 100;
        }
        //member methods

        public void AttackARobo(Robot robot)
        {
            robot.robotHealth -= dinoPower;
            dinoEnergy -= (2 * dinoPower);
        }
        public void RegenerateEnergy()
        {
            dinoEnergy = 100;
        }
        

        
    }
}

