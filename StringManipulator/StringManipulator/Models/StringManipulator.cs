namespace StringManipulator.Models
{
    /*
  * Definisco una classe astratta che rappresenta un "manipolatore di stringhe". 
  * Questa classe astratta serve da base per eventuali algoritmi di manipolazione delle stringhe 
  * che possono essere implementate in futuro (es. ricerca parola più corta.)
  */
    public abstract class StringManipulator
    {
        /*
         * Metodo astratto che deve essere implementato dalle classi derivate.
         * Prende una stringa in input e restituisce una stringa manipolata (ad es., la parola più lunga).
         */
        public abstract string Manipulate(string input);
    }

}
