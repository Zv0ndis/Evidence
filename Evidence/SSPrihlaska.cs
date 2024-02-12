using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence
{
    internal class SSPrihlaska : Prihlaska
    {
        int PointInExam;
        SSPrihlaska(string Name,string Surname,DateTime Dob,string Obor,bool Accepted,int PointsinExam) 
            : base(Name,Surname,Dob,Obor,Accepted)
        { 
            PointInExam = PointsinExam;
        }

    }
}
