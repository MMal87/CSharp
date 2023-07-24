using System;
using System.Text;

namespace WordGame {
    public class Game
    {
        public int counter;
        public string word;
        private readonly WordChoser wordChoser;
        private List<char> guessedLetters = new List<char>();

        public Game(WordChoser wordChoser)
        {
            this.wordChoser = wordChoser;
            counter = 10;
            word = wordChoser.GetRandomWordFromDictionary();

            
        }
     
        public string GetWordToGuess(char guess)
        {
             counter--; // decrement counter variable by 1
            StringBuilder builder = new StringBuilder(); // new instance of StringBuilder class
             // initialize a list to store guessed letters


    for (int i = 0; i < word.Length; i++) // loop over characters of 'word'. i is the loop counter
    {
        char currentLetter = word[i]; // retrieve the character at index i from 'word' string and assign it to 'currentLetter'

        if (guessedLetters.Contains(currentLetter) || currentLetter == guess) // check if character i in guess is the same as currentLetter
        {
            guessedLetters.Add(currentLetter);// add the guessed letter to the list of guessed letters
            builder.Append(currentLetter); // if letters match, currentLetter is appended to 'builder' string
        }
        else
        {
            builder.Append("_"); // otherwise, underscore is appended to builder string
        }
//    if (guess == currentLetter)
//         {
//             guessedLetters.Add(guess); // add the guessed letter to the list of guessed letters
//         }
    }

    // Append underscores for the missing letters
    for (int i = builder.Length; i < word.Length; i++)
    {
        builder.Append("_");
    }

    return builder.ToString();//converts builder string to regular string and returns it
        
        }

        public int GetRemainingAttempts()
        {
            return counter;
        }
        
        public bool GuessLetter(char letter){
                var guessedLetters = new List<char>();
                if (this.word.IndexOf(letter) == -1) {
                    counter --;
                    return false;
                }else {
                    guessedLetters.Add(letter);
                    return true;
                }
                

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




