using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence
{
    public class Prihlaska
    {
        string Name;
        string Surname;
        DateTime DoB;
        string Obor;
        bool Accepted;

        public Prihlaska(string Name,string Surname,DateTime DoB,string Obor,bool Accepted)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.DoB = DoB;
            this.Obor = Obor;
            this.Accepted = Accepted;
            this.DoB = DoB;
        }

    }
}
