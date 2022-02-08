namespace MorseCodeAlphabet
{
    public static class UsingIf
    {
        public static string GetMorseCode(char c)
        {
            // TODO #1. Implement the method using "if" statement. The method should return a Morse code sequence using "." symbol as dot and "-" symbol as dash.
            if (c == 'A' || c == 'a')
            {
                return ".-";
            }

            return string.Empty;
        }
    }
}
