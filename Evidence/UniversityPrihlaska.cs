using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence
{
    internal class UniversityPrihlaska :Prihlaska
    {
        double Average;
        UniversityPrihlaska(string Name, string Surname, DateTime Dob, string Obor, bool Accepted, double Average)
            : base(Name, Surname, Dob, Obor, Accepted)
        {
            this.Average = Average;
        }
    }
}
