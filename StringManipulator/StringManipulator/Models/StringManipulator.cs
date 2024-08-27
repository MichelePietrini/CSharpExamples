namespace StringManipulator.Models
{
  /// <summary>
  /// Classe astratta per la manipolazione di stringhe.
  /// </summary>
  public abstract class StringManipulator
  {
    /// <summary>
    /// Metodo astratto per manipolare una stringa.
    /// </summary>
    /// <param name="input">La stringa da manipolare.</param>
    /// <returns>La stringa manipolata.</returns>
    public abstract string Manipulate(string input);
  }

}
