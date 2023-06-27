namespace WordGame.Tests;

public class GameTest
{
    [SetUp]
    public void Setup()
    {
    }

    // [Test]
    // public void For_Returning_Word_Get_Word()
    // {
    //     //Arrange - creating objects
    //     WordGame.Game game = new WordGame.Game("MAKERS");
    //     //ACt-call the method under test
    //     string actual = game.GetWordToGuess("MORONO");
    //     string expected = "M_____";
    //     //Assert - asssert that the method did what it should
    //     Assert.AreEqual(expected, actual);
    // }
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
    [Test]
        public void TestRandomWordSelection()
        {
            // Arrange
            Game game = new Game();
            
            // Act
            string wordToGuess = game.GetRandomWordFromDictionary();
            string guess = "TABLE";
            game.word = wordToGuess; // Provide a guess if needed

            // Assert
            string result = game.GetWordToGuess(guess);
            Assert.IsFalse(string.IsNullOrEmpty(wordToGuess));
            Assert.AreEqual(wordToGuess.Length, result.Length);
            
            }

}