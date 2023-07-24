using System;

namespace WordGame 
{
    class Program
    {
        static void Main(string[] args)
    {

    Console.WriteLine("Welcome to the Word Game!");
    var wordChoser = new WordChoser();
    var game = new Game(wordChoser);

    Console.WriteLine("Welcome to the Word Game!");
    Console.WriteLine("Guess the letters to reveal the word.");

    while (game.GetRemainingAttempts() > 0)
    {
        Console.WriteLine($"Remaining attempts: {game.GetRemainingAttempts()}");
        Console.Write("Enter a letter: ");
        string input = Console.ReadLine();

        Console.WriteLine();

        char letter = char.ToUpper(input[0]);
        bool guessedCorrectly = game.GuessLetter(letter);

        if (guessedCorrectly)
        {
            Console.WriteLine("Correct guess!");
        }
        else
        {
            Console.WriteLine("Incorrect guess!");
        }

        string wordToGuess = game.GetWordToGuess(letter);
        Console.WriteLine($"Word to guess: {wordToGuess}");

        if (wordToGuess.IndexOf('_') == -1)
        {
            Console.WriteLine("Congratulations! You guessed the word correctly.");
            break;
        }
    }

    if (game.GetRemainingAttempts() == 0)
    {
        Console.WriteLine("Game over! You have used all your attempts.");
        Console.WriteLine($"The word to guess was: {game.word}");
    }

    Console.WriteLine("Thank you for playing the Word Game!");
}
}
}

