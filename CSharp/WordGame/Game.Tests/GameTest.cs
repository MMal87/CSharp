using NUnit.Framework;
using NSubstitute;
using WordGame;

namespace WordGame.Tests;

public class GameTest
{
    [SetUp]
    public void Setup()
    {
    }

    // [Test]
    // public void reduce_attmept_count_by_one()
    // {
    //     //Arrange - creating objects
    //     WordGame.Game game = new WordGame.Game("MAKERS");
    //     //ACt-call the method under test
    //    game.GetWordToGuess("MORONO");
    //    game.GetWordToGuess("BURAND");
    //    int expected = game.GetRemainingAttempts();
    //    int actual = 8;

    //     //Assert - asssert that the method did what it should
    //     Assert.AreEqual(expected, actual);
    // }

    
    //          [Test]
    //     public void TestRandomWordSelection()
    //     {
    //         // Arrange
    //         Game game = new Game();
            
    //         // Act
    //         string wordToGuess = game.GetRandomWordFromDictionary();
    //         string guess = "TABLE";
    //         game.word = wordToGuess; // Provide a guess if needed

    //         // Assert
    //         string result = game.GetWordToGuess(guess);
    //         Assert.IsFalse(string.IsNullOrEmpty(wordToGuess));
 
            
    //         }

        [Test]
public void Test_Game_With_Mocked_WordChoser()
{
    // Arrange
    var wordChoser = Substitute.For<WordChoser>();
    wordChoser.GetRandomWordFromDictionary().Returns("CHOCOLATE");
    var game = new Game(wordChoser);

    string wordToGuess = game.word;
    string guess = "TABLEE";
    
    var gameUnderTest = new Game(wordChoser);

    // Act
    string result = game.GetWordToGuess(guess);

    // Assert
    Assert.AreEqual("_________", result);
}
}

