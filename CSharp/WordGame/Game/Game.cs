using System;
using System.Text;

namespace WordGame {
    public class Game
    {
        public int counter;
        public string word;
        private readonly WordChoser wordChoser;

        public Game(WordChoser wordChoser)
        {
            this.wordChoser = wordChoser;
            counter = 10;
            word = wordChoser.GetRandomWordFromDictionary();

            
        }
     
        public string GetWordToGuess(string guess)
        {
            counter--;//decrement counter variable by 1
            StringBuilder builder = new StringBuilder();//new instance of stringbuilder class
            for (int i = 0; i < word.Length; i++) //starts loop that iterates over characters of 'guess'. i is the loop counter
            {
                char currentLetter = word[i];//retrieves the character at index i from 'word' string and assigns it to 'current letter'

                if (guess.Length > i && guess[i] == currentLetter) {//checks if character i in guess is same as currentletter
                    builder.Append(currentLetter);//if letters match, currentletter is appended to 'builder'string
                } else {
                    builder.Append("_");//otherwise, underscore is appended to builder string
                }
            }
            return builder.ToString();//converts builder string to regular string and returns it
        }

        public int GetRemainingAttempts()
        {
            return counter;
        }
    }

    public class WordChoser {
        public readonly string[] DICTIONARY = {"MAKERS", "CANDIES", "DEVELOPER", "LONDON"};

        public virtual string GetRandomWordFromDictionary() {
            Random rand = new Random();
            return DICTIONARY[rand.Next(DICTIONARY.Length)];
        }
    }
}

