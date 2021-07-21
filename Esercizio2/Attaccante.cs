using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio2
{
    class Attaccante : SoccerPlayer
    {
        public int Goal { get; set; }
        public Attaccante(int NumberJersey, string FirstName, string LastName, int Age, RoleEnum Role, int Goal)
            : base(NumberJersey, FirstName, LastName, Age, Role)
        {
            Role = RoleEnum.Attaccante;
            this.Goal = Goal;
        }

    }
}
