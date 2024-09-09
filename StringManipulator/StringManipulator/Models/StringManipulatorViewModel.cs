using StringManipulator.Interfaces;
using System.Data.SqlTypes;

namespace StringManipulator.Models
{
    public class StringManipulatorViewModel : IStringManipulator
    {
        public string LongestWordManipulator(string input)
        {
            if (input is null)
            {
                throw new ArgumentNullException(nameof(input), "Parameter cannot be null.");
            }

            if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
            {
                return string.Empty;
            }

            var words = input.Split(new[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            return words.OrderByDescending(w => w.Length).First();
        }

        public string ShortestWordManipulator(string input)
        {
            var words = input.Split(new[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            return words.OrderBy(w => w.Length).First();
        }


    }
}
