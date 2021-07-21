using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio2
{
    class Centrocampista : SoccerPlayer
    {
        public int Assist { get; set; }
        public Centrocampista(string FirstName, string LastName, int Age, RoleEnum Role, int NumberJersey, int GoalsTaken)
            : base(NumberJersey, FirstName, LastName, Age, Role)
        {
            Role = RoleEnum.Centrocampista;
            this.Assist = Assist;
        }

        public Centrocampista()
        {

        }
    }
}
