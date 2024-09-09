using StringManipulator.Interfaces;
using StringManipulator.Models;

namespace StringManipulatorTest
{
    public class StringManipulatorTests
    {
        private readonly IStringManipulator _stringManipulator;

        public StringManipulatorTests()
        {
            _stringManipulator = new StringManipulatorViewModel();
        }
        [Fact]
        public void LongestWordManipulator_InputIsNull_ThrowsArgumentNullException()
        {
            // Arrange
            string? input = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => _stringManipulator.LongestWordManipulator(input!));
        }

        [Fact]
        public void LongestWordManipulator_InputIsEmpty_ReturnsEmptyString()
        {
            // Arrange
            string input = string.Empty;
            

            // Act
            var result = _stringManipulator.LongestWordManipulator(input);

            // Assert
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void LongestWordManipulator_InputHasSingleWord_ReturnsThatWord()
        {
            // Arrange
            string input = "Hello";
            

            // Act
            var result = _stringManipulator.LongestWordManipulator(input);

            // Assert
            Assert.Equal("Hello", result);
        }


        [Fact]
        public void LongestWordManipulator_InputHasMultipleWordsWithSameLength_ReturnsFirstLongestWord()
        {
            // Arrange
            string input = "The quick brown fox jumps over the lazy dogs";
            

            // Act
            var result = _stringManipulator.LongestWordManipulator(input);

            // Assert
            Assert.Equal("quick", result);
        }

        [Fact]
        public void LongestWordManipulator_InputHasPunctuation_ReturnsLongestWordIgnoringPunctuation()
        {
            // Arrange
            string input = "Hello, world! This is a test.";
            

            // Act
            var result = _stringManipulator.LongestWordManipulator(input);

            // Assert
            Assert.Equal("Hello", result); // "Hello" and "world" both have 5 characters, "Hello" comes first.
        }

        [Fact]
        public void LongestWordManipulator_InputHasSpecialCharacters_ReturnsLongestWord()
        {
            // Arrange
            string input = "Testing with special-characters like # and $!";
            

            // Act
            var result = _stringManipulator.LongestWordManipulator(input);

            // Assert
            Assert.Equal("special-characters", result); // Since special-characters is the longest word
        }

        [Fact]
        public void LongestWordManipulator_InputHasOnlySpaces_ReturnsEmptyString()
        {
            // Arrange
            string input = "     "; // Only spaces
            

            // Act
            var result = _stringManipulator.LongestWordManipulator(input);

            // Assert
            Assert.Equal(string.Empty, result);
        }



        [Fact]
        public void LongestWordManipulator_InputHasNumbers_ReturnsLongestWordWithNumbers()
        {
            // Arrange
            string input = "There are 12345 numbers in this sentence";
            

            // Act
            var result = _stringManipulator.LongestWordManipulator(input);

            // Assert
            Assert.Equal("sentence", result); // "sentence" is the longest word
        }
    }
}