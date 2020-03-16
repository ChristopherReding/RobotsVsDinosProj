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
        public int dinoEnergy; //energy will be required to attack during 'take turn'
        public int dinoPower; //strength dino's attack, determined by chosen attack method

        //constructor
        public Dinosaur(string type, int health, int power)
        {
            this.dinoType = type;
            this.dinoHealth = health;
            this.dinoPower = ChooseAttackMethod(); 
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

        public int ChooseAttackMethod()
        {
            DinoAttack chomp = new DinoAttack("Chomp", 20);
            DinoAttack tailWhip = new DinoAttack("Tail Whip", 10);
            DinoAttack stomp = new DinoAttack("Foot stomp", 15);
            DinoAttack[] dinoAttacksArray = { chomp, tailWhip, stomp };            
            Console.WriteLine($"Which attack would you like {dinoType} to use?");
            int i = 1;
            foreach (DinoAttack dinoAttack in dinoAttacksArray)
            {                
                Console.WriteLine($"{i}) {dinoAttacksArray[i-1].attackMethod}");
                i++;
            }
            int indexOfChosenAttackMethod = Convert.ToInt32(Console.ReadLine())-1;
            Console.WriteLine($"{dinoType} will attack with {dinoAttacksArray[indexOfChosenAttackMethod].attackMethod}\n");
            return dinoAttacksArray[indexOfChosenAttackMethod].attackPower;
        }        
    }
}

