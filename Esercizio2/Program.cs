using System;
using System.Collections.Generic;

namespace Esercizio2
{   //            Creare un programma che consente di gestire una squadra di calcio per una partita.
    //Gli atleti hanno nome, cognome, età

    //I Calciatori hanno anche ruolo e numero maglia(ruoli = centrocampista, difensore, portiere e attaccante)
    //I Portieri hanno numero maglia = 1(di default) e anche il numero di goal subiti.
    //Gli attaccanti hanno anche il numero goal fatti in una partita
    //Il centrocampista ha anche il numero di assist in una partita. Il difensore ha anche il numero di recuperi palla.

    //Una squadra di calcio è formata da 11 calciatori di cui:
    //            1 portiere
    //4 difensori
    //3 centrocampisti
    //3 attaccanti

    //Per svolgere una partita serve anche un arbitro.
    //L'arbitro è un atleta, ma ha anche il numero di anni di carriera.
    class Program
    {
        static void Main(string[] args)
        {
            List<SoccerPlayer> Italia = new List<SoccerPlayer>()
            {
                new Portiere("Gianluigi", "Donnaruma", 22, 5 ),
                new Difensore(2, "Giorgio", "Chiellini", 30, 10),
                new Attaccante(3, "Lorenzo", "Insigne", 19, 2),
                new Attaccante(4, "Federico", "Chiesa", 20, 5),
                new Attaccante(5, "Ciro", "Immobile", 21,0),
                new Centrocampista(6, "Jorge", "Frello", 27, 3 )


            };


        }
    }
}
