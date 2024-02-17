using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence
{
    internal class UApplication : Application
    {
        public double Average { get; set; }

        public UApplication(string iD,string name, string surname, DateTime dob, string study, double average, double points,bool accepted)
            :base(iD, name,surname,dob, study, points,accepted)
        { 
            Average = average;
        }
    }
}
