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
            robotPowerLevel = 100;
            this.robotAttackPower = PickUpWeapon(); 


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
       public int PickUpWeapon()
        {            
            Weapon rayGun = new Weapon("Ray Gun", 20);
            Weapon sword = new Weapon("Sword", 15);
            Weapon roboFist = new Weapon("Robo-Fist", 10);
            List<Weapon> weapons = new List<Weapon>() { rayGun, sword, roboFist };
            Console.WriteLine($"Please choose number of weapon you would like {robotName} to use");
            for(int i = 0; i< weapons.Count; i++)
            {
                Console.WriteLine($"{i+1}) {weapons[i].weapon}");
            }
            
            int indexOfChosenWeapon = Convert.ToInt32(Console.ReadLine())-1;
            Console.WriteLine($"You armed {robotName} with the {weapons[indexOfChosenWeapon].weapon}\n");
            return weapons[indexOfChosenWeapon].attackPower;


        }

    }
}

