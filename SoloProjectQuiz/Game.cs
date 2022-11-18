using System;
using System.Collections.Generic;
using System.Text;

namespace SoloProjectQuiz
{
    class Game
    {
        //Fields
        private string GameTitle = "Leons Quiz";
        private string Description = "Försök svara så många rätt för att få så mycket poäng som möjligt!";
        public Player CurrentPlayer;
        private Quiz CapitalLeon;
        private Quiz CountriesLeon;
        private Quiz AnimalLeon;
        private Quiz FinlandLeon;
        
        public Game()
        {
            string CapitalQuestion = "Är huvudstaden i Sverige Stockholm? - true or false ?";
            CapitalLeon = new Quiz(CapitalQuestion, "true");
            

            string AmountCountriesQuestion = "Finns det exakt 234 länder på jorden? - true or false?";
            CountriesLeon = new Quiz(AmountCountriesQuestion, "false");

            string BiggestAnimalQuestion = "Är val det sörsta däggdjuret på våran planet? - true or false?";
            AnimalLeon = new Quiz(BiggestAnimalQuestion, "true");

            string FinlandQuestion = "Heter Finlands huvudstad Helsingborg? - true or false?";
            FinlandLeon = new Quiz(FinlandQuestion, "false");

        }
        
        public void Play() //Metod som kör spelet 
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
            Console.WriteLine("---------------------------------------------------------");
            AnimalLeon.AskQ();
            Console.WriteLine("---------------------------------------------------------");
            FinlandLeon.AskQ();
           
            

            Console.WriteLine("\nTryck på en knapp för att avsluta.");
            Console.ReadKey();
        }        
    }
}
