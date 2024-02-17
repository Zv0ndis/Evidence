using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence
{
    public class Application
    {
        public string Id;
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Dob { get; set; }
        public string Study { get; set; }
        public double Points { get; set; }
        public bool Accepted { get; set; }


        public Application(string id,string name,string surname,DateTime dob,string study, double points,bool accepted) 
        {
            Id = id;
            Name = name;
            Surname = surname;
            Dob = dob;
            Study= study;
            Accepted = accepted;
            Points = points;
        }

    }
}
