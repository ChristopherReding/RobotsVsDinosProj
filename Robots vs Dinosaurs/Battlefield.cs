using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    class Battlefield
    {
        //member variable
        public Herd dinoHerd;
        public Fleet roboFleet;
        //constructor
        public Battlefield()
        {
            dinoHerd = new Herd();
            roboFleet = new Fleet();
        }

        //member methods
        public void PlayAGame()
        {
            int round = 0;
            while (dinoHerd.dinosaurs.Count > 0 && roboFleet.robots.Count > 0)
            {                                
                Console.WriteLine($"Results of round {round}:\n");
                foreach(Dinosaur dinosaur in dinoHerd.dinosaurs)
                {
                    Console.WriteLine($"{dinosaur.dinoType}) Health: {dinosaur.dinoHealth}  Energy: {dinosaur.dinoEnergy}");
                }
                Console.WriteLine(" ");
                foreach(Robot robot in roboFleet.robots)
                {
                    Console.WriteLine($"{robot.robotName}) Health: {robot.robotHealth}  Power: {robot.robotPowerLevel} ");
                }
                Console.ReadLine();
                Console.WriteLine("\n\n");
                PlayARound();
                round++;
                Console.ReadLine();

            }
            
            if (dinoHerd.dinosaurs.Count == 0 && roboFleet.robots.Count == 0)
            {
                Console.WriteLine("MUTUAL DESTRUCTION! Both teams were destroyed Thanks for playing!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else if(dinoHerd.dinosaurs.Count == 0)
            {
                Console.WriteLine("Dinosaurs were destroyed, Robots win! Thanks for playing!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else if(roboFleet.robots.Count == 0)
            {
                Console.WriteLine("Robots were destroyed, Dinosaurs rule the earth Thanks for playing!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else
            {
                PlayARound();
            }
        }
        public void PlayARound()
        {
            if (FlipACoin() == true) 
            {
                Console.WriteLine("Dinosaurs attack first!\n");
                TakeATurnDinos();
                Console.WriteLine("Now it's the robot's turn to attack\n");
                Console.ReadLine();
                TakeATurnRobots();
            }
            else
            {
                Console.WriteLine("Robots attack first!\n");
                TakeATurnRobots();
                Console.WriteLine("Now it's the dinosaurs turn to attack\n");
                Console.ReadLine();
                TakeATurnDinos();
            }

        }

        public bool FlipACoin()
        {
            Random randomNumber = new Random();
            int number = randomNumber.Next(99);
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void TakeATurnDinos()
        {            
            for (int i = 0; i < dinoHerd.dinosaurs.Count; i++)
            {
                if (dinoHerd.dinosaurs[i].dinoEnergy <= 0)
                {
                    Console.WriteLine($"{dinoHerd.dinosaurs[i].dinoType} needs to rest.\n");
                    dinoHerd.dinosaurs[i].RegenerateEnergy();                    
                }
                else
                { 
                    int j;
                    Console.WriteLine($"{dinoHerd.dinosaurs[i].dinoType}: Select number of robot you would like to attack");
                    for (j = 0; j < roboFleet.robots.Count; j++)
                    {
                        Console.WriteLine($" {j+1}: {roboFleet.robots[j].robotName}");                        
                    }
                    int attackedRobot = Convert.ToInt32(Console.ReadLine()) - 1;                    
                    if (FlipACoin() == true)
                    {
                        Console.WriteLine($"{dinoHerd.dinosaurs[i].dinoType} successfully attacks {roboFleet.robots[attackedRobot].robotName}\n");
                        dinoHerd.dinosaurs[i].AttackARobo(roboFleet.robots[attackedRobot]);
                        if (roboFleet.robots[attackedRobot].robotHealth <= 0)
                        {
                            roboFleet.robots.Remove(roboFleet.robots[attackedRobot]);
                        }

                    }
                    else
                    {
                        Console.WriteLine($"{dinoHerd.dinosaurs[i].dinoType} missed\n");
                    }

                }

            }
        }

        public void TakeATurnRobots()
        {
            for (int i = 0; i < roboFleet.robots.Count; i++)
            {
                if (roboFleet.robots[i].robotPowerLevel <= 0)
                {
                    Console.WriteLine($"{roboFleet.robots[i].robotName} needs to rest.\n");
                    roboFleet.robots[i].RegeneratePower();
                }
                else
                {
                    int j;
                    Console.WriteLine($"{roboFleet.robots[i].robotName}: Select number of dinosaur you would like to attack");
                    for (j = 0; j < dinoHerd.dinosaurs.Count; j++)
                    {
                        Console.WriteLine($" {j+1}: {dinoHerd.dinosaurs[j].dinoType}");
                    }
                    int attackedDinosaur = Convert.ToInt32(Console.ReadLine()) - 1;                    
                    if(FlipACoin() == true)
                    {
                        Console.WriteLine($"{roboFleet.robots[i].robotName} successfully attacks {dinoHerd.dinosaurs[attackedDinosaur].dinoType}\n");
                        roboFleet.robots[i].AttackADino(dinoHerd.dinosaurs[attackedDinosaur]);
                        if(dinoHerd.dinosaurs[attackedDinosaur].dinoHealth <= 0)
                        {
                            dinoHerd.dinosaurs.Remove(dinoHerd.dinosaurs[attackedDinosaur]);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{roboFleet.robots[i].robotName} missed\n");
                    }
                    
                }
            }
        }


    }
}
