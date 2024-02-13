using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence
{
    internal class UApplication : Application
    {
        double average;

        public UApplication(string name, string surname, DateTime dob, string study, double average, double points,bool accepted)
            :base(name,surname,dob, study, points,accepted)
        { 
            this.average = average;
        }
    }
}
