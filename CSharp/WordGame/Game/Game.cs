using System;
using System.Text;

namespace WordGame {
    public class Game
    {
        public int counter;
        public string word;

   
        private readonly string[] Dictionary = {"MAKERS", "CANDIES", "DEVELOPER", "LONDON"};
    

        public Game()
        {
            counter = 10;
            
        }
        public string GetRandomWordFromDictionary(){

            Random random = new Random();
            int index = random.Next(0, Dictionary.Length);
            word = Dictionary[index];
            return word;


        }

        public string GetWordToGuess(string guess)
        {
            counter --;
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < guess.Length; i++) 
            {
                char currentLetter = word[i];

                if (guess[i] == currentLetter) {
                    builder.Append(currentLetter);
                } else {
                    builder.Append("_");
                }
            }
            return builder.ToString();

                }

            public int GetRemainingAttempts(){
                return counter;

                }
            }
}

