using System;
using System.Collections.Generic;
using System.Text;

namespace SoloProjectQuiz
{
    class Player
    {
        public string Name;
        public int Score;  

        public Player(string PlayerName) //Lagrar spelarens namn och poäng
        {
            Name = PlayerName;
            Score = 0; 
           
        }
    }
}
