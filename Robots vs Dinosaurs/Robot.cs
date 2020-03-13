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
        public int robotHealth; //robot dies when this hits 0
        public int robotPowerLevel; //energy will be required to attack during take turn
        public Weapon weapon; //
        

        //constructor
        public Robot(string roborobotNametType, int robotHealth)
        {
            this.robotName = roborobotNametType;
            this.robotHealth = robotHealth;
            void ChooseWeapon()
            {

            }


        }
        //member methods
    }
}

