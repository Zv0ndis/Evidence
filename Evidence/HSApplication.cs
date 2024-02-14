using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence
{
    internal class HSApplication : Application
    {
        public HSApplication(string iD,string name,string surname,DateTime dob,string study,double points, bool accepted) 
            : base(iD,name,surname,dob,study, points,accepted)
        { 
        }

    }
}
