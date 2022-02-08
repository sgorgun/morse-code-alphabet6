namespace MorseCodeAlphabet
{
    public static class UsingSwitch
    {
        public static byte GetMorseCode(char c)
        {
            // TODO #2. Implement the method using "switch/case" statements. The number should be represented the code as a binary literal.
            switch (c)
            {
                case 'A':
                case 'a':
                    return 0b0011_0001;

                default:
                    return 0b0000_0000;
            }
        }
    }
}
