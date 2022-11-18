using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace SoloProjectQuiz
{
    class Quiz
    {
        private string Question;
        private string Answer;
        public Quiz(string leonQuestion, string leonAnswer)
        {
            //Att göra: Ändra så ordningen på svaren och frågan
            Question = leonQuestion;
            Answer = leonAnswer;

        }

        public bool AskQ()
        {
            //Visar frågan, ger response
            //Sedan visar det rätta svaret
            WriteLine(Question);
            Write($"Vad är ditt svar?: ");
            string PlayerAnswer = ReadLine();
                if (PlayerAnswer == Answer) // Checkar om spelaren hade rätt
                {
                    WriteLine("Du svarade rätt!");
                    return true;
                }
                else
                {
                    WriteLine($"Du svarade '{PlayerAnswer}'");
                    WriteLine($"Det rätta svaret är: {Answer}");
                    return false;
                }

        }
       
    }
}
