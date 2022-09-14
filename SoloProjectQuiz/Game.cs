using System;
using System.Collections.Generic;
using System.Text;

namespace SoloProjectQuiz
{
    class Game
    {




        private Player CurrentPlayer;
        public Game()
        {

        }
        public void Play()
        {
            Console.WriteLine("Välkommen till min quiz!");
            Console.WriteLine("Tryck på en knapp för att avsluta.");
            Console.ReadKey();
        }


    }
}
