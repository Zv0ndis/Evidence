using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence
{
    public class Application
    {
        string id;
        string name;
        string surname;
        DateTime dob;
        string study;
        double points;
        bool accepted;


        public Application(string id,string name,string surname,DateTime dob,string study, double points,bool accepted) 
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.dob = dob;
            this.study = study;
            this.accepted = accepted;
            this.points = points;
        }

    }
}
