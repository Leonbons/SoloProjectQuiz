using System;
using System.Collections.Generic;
using System.Text;

namespace SoloProjectQuiz
{
    class Game
    {


        private string GameTitle = "Leons Quiz";
        private string Description = "Försök svara så många rätt för att få så mycket poäng som möjligt!";
        private Player CurrentPlayer;
        private Quiz CapitalLeon;
        private Quiz CountriesLeon;
        
        public Game()
        {
             
                string CapitalQuestion = "Är huvudstaden i Sverige Stockholm? - true or false ?";
                CapitalLeon = new Quiz(CapitalQuestion, "true");


            string AmountCountriesQuestion = "Finns det exakt 234 länder på jorden? - true or false?";
            CountriesLeon = new Quiz(AmountCountriesQuestion, "false");

        }
        public void Play()
        {
            Console.WriteLine("Välkommen till " + GameTitle);
            Console.WriteLine(Description);
            Console.WriteLine("Skriv ditt namn nedanför");
            string PlayerName = Console.ReadLine();
            CurrentPlayer = new Player(PlayerName);
            Console.WriteLine($"Välkommen till {GameTitle}, {CurrentPlayer.Name}!");
            Console.WriteLine($"Du kommer att starta med {CurrentPlayer.Score} poäng.");

            Console.WriteLine("---------------------------------------------------------");
            CapitalLeon.AskQ();
            Console.WriteLine("---------------------------------------------------------");
            CountriesLeon.AskQ();
            

            Console.WriteLine("\nTryck på en knapp för att avsluta.");
            Console.ReadKey();
        }


    }
}
