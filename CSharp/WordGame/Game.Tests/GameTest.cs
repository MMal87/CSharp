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

//         [Test]
// public void Test_Game_With_Mocked_WordChoser()
// {
//     // Arrange
//     var wordChoser = Substitute.For<WordChoser>();
//     wordChoser.GetRandomWordFromDictionary().Returns("CHOCOLATE");
//     var game = new Game(wordChoser);

//     string wordToGuess = game.word;
//     string guess = "TABLEE";
    


//     // Act
//     string result = game.GetWordToGuess(guess);

//     // Assert
//     Assert.AreEqual("_________", result);
// }

[Test]
public void test_GuessLetter_method_true()
{
    var wordChoser = Substitute.For<WordChoser>();
    wordChoser.GetRandomWordFromDictionary().Returns("MAKERS");
    var game = new Game(wordChoser);
    var actual = game.GuessLetter('A');
    var expected = true;
    Assert.AreEqual(actual, expected);

}
[Test]
public void test_GuessLetter_method_false()
{
    var wordChoser = Substitute.For<WordChoser>();
    wordChoser.GetRandomWordFromDictionary().Returns("MAKERS");
    var game = new Game(wordChoser);
    var actual = game.GuessLetter('Z');
    var expected = false;
    Assert.AreEqual(actual, expected);

}
[Test]
public void test_GuessLetter_method_decrememnts_counter()
{
    var wordChoser = Substitute.For<WordChoser>();
    wordChoser.GetRandomWordFromDictionary().Returns("MAKERS");
    var game = new Game(wordChoser);
    game.GuessLetter('Z');
    Assert.AreEqual(9, game.GetRemainingAttempts());

}
 [Test]
public void Test_Game_With_Mocked_WordChoser_guessLetter()
{
    // Arrange
    var wordChoser = Substitute.For<WordChoser>();
    wordChoser.GetRandomWordFromDictionary().Returns("CHOCOLATE");
    var game = new Game(wordChoser); 
    game.GuessLetter('E');
    string result = game.GetWordToGuess('E');
  
    Assert.AreEqual("________E", result);
}
 [Test]
public void Test_Game_With_Mocked_WordChoser_guessLetter_two_times()
{
    // Arrange
    var wordChoser = Substitute.For<WordChoser>();
    wordChoser.GetRandomWordFromDictionary().Returns("CHOCOLATE");
    var game = new Game(wordChoser); 
    game.GuessLetter('C');
    game.GuessLetter('H');
    string result = game.GetWordToGuess('C');
    Assert.AreEqual("C__C_____", result);
    result = game.GetWordToGuess('H');
    Assert.AreEqual("CH_C_____", result);
  
    
}

}

