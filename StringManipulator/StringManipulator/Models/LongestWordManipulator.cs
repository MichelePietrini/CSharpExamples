namespace StringManipulator.Models
{

    public class LongestWordManipulator : StringManipulator
    {
        public override string Manipulate(string input)
        {
            var words = input.Split(new[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            return words.OrderByDescending(w => w.Length).First();

        }
    }
}
