namespace StringManipulator.Models
{

    /// <summary>
    /// Classe che implementa la manipolazione di una stringa restituendo la parola più lunga.
    /// </summary>
    public class LongestWordManipulator : StringManipulator
    {
        /// <summary>
        /// Manipola la stringa di input restituendo la parola più lunga.
        /// </summary>
        /// <param name="input">La stringa di input da manipolare.</param>
        /// <returns>La parola più lunga nella stringa di input.</returns>
        public override string Manipulate(string input)
        {
            var words = input.Split(new[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            return words.OrderByDescending(w => w.Length).First();
        }
    }
}
