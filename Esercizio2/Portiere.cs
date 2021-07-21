using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio2
{
    class Portiere : SoccerPlayer
    {   public int GoalsTaken { get; set; }
        public Portiere(int NumberJersey, string FirstName, string LastName, int Age, RoleEnum Role, int GoalsTaken)
             : base(NumberJersey, FirstName, LastName, Age, Role)
        {
            
            Role = RoleEnum.Portiere;
            this.GoalsTaken = GoalsTaken;
        }

        public Portiere(string FirstName, string LastName, int Age, RoleEnum Role, int GoalsTaken)
            : base(FirstName, LastName, Age, Role)
        {
            NumberJersery = 1;
            Role = RoleEnum.Portiere;
            this.GoalsTaken = GoalsTaken;
        }
    }
}
