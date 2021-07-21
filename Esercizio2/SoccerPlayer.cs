using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio2
{
    abstract class SoccerPlayer : Athlete
    {
        public RoleEnum Role { get; set; }
        public int NumberJersery { get; set; }

        public SoccerPlayer(int NumberJersey, string FirstName, string LastName, int Age, RoleEnum Role)
            :base(FirstName, LastName, Age)
            {
            this.Role = Role;
            this.NumberJersery = NumberJersey;
            }
        
        public SoccerPlayer(string FirstName, string LastName, int Age, RoleEnum Role)
            : base(FirstName, LastName, Age)
        {
            this.Role = Role;
            
        }

  
        
    }

    enum RoleEnum
    {
        Portiere,
        Difensore,
        Centrocampista,
        Attaccante
    }
}
