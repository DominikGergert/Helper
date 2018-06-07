using System;

public class Helper
{
    public Helper()
    {





    }
    public string RemoveSonderzeichenAndWhitespace(string Removesonderzeichen)
    {
        if (Removesonderzeichen.Contains(";"))
            Removesonderzeichen.Replace(';', ' ');

        if (Removesonderzeichen.Contains("/"))
            Removesonderzeichen.Replace('/', ' ');

        if (Removesonderzeichen.Contains("("))
            Removesonderzeichen.Replace('(', ' ');

        if (Removesonderzeichen.Contains(")"))
            Removesonderzeichen.Replace(')', ' ');

        if (Removesonderzeichen.Contains("|"))
            Removesonderzeichen.Replace('|', ' ');

        if (Removesonderzeichen.Contains("{"))
            Removesonderzeichen.Replace('{', ' ');

        if (Removesonderzeichen.Contains("^"))
            Removesonderzeichen.Replace('^', ' ');

        if (Removesonderzeichen.Contains(","))
            Removesonderzeichen.Replace(',', ' ');

        if (Removesonderzeichen.Contains("="))
            Removesonderzeichen.Replace('=', ' ');

        if (Removesonderzeichen.Contains("+"))
            Removesonderzeichen.Replace('+', ' ');

        if (Removesonderzeichen.Contains("!"))
            Removesonderzeichen.Replace('!', ' ');

        if (Removesonderzeichen.Contains("§"))
            Removesonderzeichen.Replace('§', ' ');

        if (Removesonderzeichen.Contains("$"))
            Removesonderzeichen.Replace('$', ' ');

        if (Removesonderzeichen.Contains("%"))
            Removesonderzeichen.Replace('%', ' ');

        if (Removesonderzeichen.Contains(";"))
            Removesonderzeichen.Replace(';', ' ');

        if (Removesonderzeichen.Contains("]"))
            Removesonderzeichen.Replace(']', ' ');

        if (Removesonderzeichen.Contains("["))
            Removesonderzeichen.Replace('[', ' ');

        if (Removesonderzeichen.Contains(";"))
            Removesonderzeichen.Replace(';', ' ');

        if (Removesonderzeichen.Contains("?"))
            Removesonderzeichen.Replace('?', ' ');

        if (Removesonderzeichen.Contains("²"))
            Removesonderzeichen.Replace('²', ' ');

        if (Removesonderzeichen.Contains("³"))
            Removesonderzeichen.Replace('³', ' ');

        if (Removesonderzeichen.Contains("´"))
            Removesonderzeichen.Replace('´', ' ');

        if (Removesonderzeichen.Contains("#"))
            Removesonderzeichen.Replace('#', ' ');

        if (Removesonderzeichen.Contains("°"))
            Removesonderzeichen.Replace('°', ' ');

        if (Removesonderzeichen.Contains("<"))
            Removesonderzeichen.Replace('<', ' ');

        if (Removesonderzeichen.Contains(">"))
            Removesonderzeichen.Replace('>', ' ');

        if (Removesonderzeichen.Contains("@"))
            Removesonderzeichen.Replace('@', ' ');

        if (Removesonderzeichen.Contains("_"))
            Removesonderzeichen.Replace('_', ' ');

        if (Removesonderzeichen.Contains(":"))
            Removesonderzeichen.Replace(':', ' ');

        if (Removesonderzeichen.Contains("€"))
            Removesonderzeichen.Replace('€', ' ');



        Removesonderzeichen.Replace(" ", "");

        return Removesonderzeichen;
    }


    /// <summary>
    /// Gibt einen Bool zurück True = Telefonnnumer False = Handynummer
    /// </summary>
    /// <param name="pTelefonnumer"></param>
    /// <returns></returns>
    public bool CheckPhoneOrHandyNumber(string pTelefonnumer)
    {
        if (pTelefonnumer.StartsWith("01"))
            return false;

        else
            return true;
    }

}
