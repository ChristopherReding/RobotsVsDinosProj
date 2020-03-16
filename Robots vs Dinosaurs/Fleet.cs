using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    class Fleet
    {
        public List<Robot> robots = new List<Robot>();

        public Fleet()
        {
            Robot roomba = new Robot("Roomba", 50, 20);
            robots.Add(roomba);
            Robot hal = new Robot("Hal", 150, 10);
            robots.Add(hal);
            Robot johnnyFive = new Robot("Johnny Five", 100, 15);
            robots.Add(johnnyFive);
        }
    }
}
