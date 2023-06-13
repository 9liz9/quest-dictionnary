namespace S04_dictionnaire;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<char, string> dictionnaire = new Dictionary<char, string>();
        dictionnaire['a'] = "abandon";
        dictionnaire['b'] = "ballad";
        dictionnaire['c'] = "cake";

        //avant suppression
        foreach (KeyValuePair<char, string> paire in dictionnaire)
        {
            Console.WriteLine("Lettre : " + paire.Key + ", Mot : " + paire.Value);
        }

        //suppression de la lettre c
        dictionnaire.Remove('c');

        // après suppression
        foreach (KeyValuePair<char, string> paire in dictionnaire)
        {
            Console.WriteLine("Lettre : " + paire.Key + ", Mot : " + paire.Value);
        }

    }
}
