using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    class Robot
    {
        //member variables

        public string robotName; //robot name
        public int robotHealth; 
        public int robotPowerLevel; //energy will be required to attack during take turn, otherwise sits turn out
        public int robotAttackPower;
        public Weapon weapon; //need to find a way to utilize this...
        

        //constructor
        public Robot(string roborobotNametType, int robotHealth, int attack)
        {
            this.robotName = roborobotNametType;
            this.robotHealth = robotHealth;
            this.robotAttackPower = attack;
            robotPowerLevel = 100;
                     
        }
        //member methods

        public void AttackADino(Dinosaur dinosaur)
        {
            dinosaur.dinoHealth -= robotAttackPower;
            robotPowerLevel -= (2 * robotAttackPower);
        }
        public void RegeneratePower()
        {
            robotPowerLevel = 100;
        }
       

    }
}

