using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio2
{
    abstract class SoccerPlayer : Athlete
    {
        private int numberJersey;

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

        public SoccerPlayer()
        {

        }

        public SoccerPlayer(int NumberJersey, string FirstName, string LastName, int Age)
            :base(FirstName,LastName, Age)
        {

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
