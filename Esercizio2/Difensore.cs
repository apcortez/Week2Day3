using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio2
{
    class Difensore: SoccerPlayer
    {
        public int BallRecoveries { get; set; }
        public Difensore(int NumberJersey, string FirstName, string LastName, int Age, RoleEnum Role, int BallRecoveries)
            : base(NumberJersey, FirstName, LastName, Age, Role)
        {
            Role = RoleEnum.Difensore;
            this.BallRecoveries = BallRecoveries;
        }

        public Difensore()
        {

        }
    }
}
