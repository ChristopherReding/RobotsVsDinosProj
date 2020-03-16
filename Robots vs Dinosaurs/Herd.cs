using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    class Herd
    {
        //member variables
        public List<Dinosaur> dinosaurs = new List<Dinosaur>();

        //constructor
        public Herd()
        {
            Dinosaur tRex = new Dinosaur("T-Rex", 100, 15);
            dinosaurs.Add(tRex);            
            Dinosaur stegasaurus = new Dinosaur("Stegasaurus", 150, 10);
            dinosaurs.Add(stegasaurus);
            Dinosaur velociraptor = new Dinosaur("velociraptor", 50, 20);        
            dinosaurs.Add(velociraptor);
        }

        


    }
}
