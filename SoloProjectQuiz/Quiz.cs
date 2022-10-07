using System;
using System.Collections.Generic;
using System.Text;

namespace SoloProjectQuiz
{
    class Quiz
    {
        private string Question;
        private string Answer;

        public Quiz(string leonQuestion, string leonAnswer)
        {
            //Att göra: Ändra så ordningen på svaren och frågan
            leonAnswer = Answer;
            leonQuestion = Question; 
        }
        public void AskQ()
        {
            //Visar frågan, ger response
            //Sedan visar det rätta svaret

            Console.WriteLine(Question);
        
        }





    }
}
