namespace MorseCodeAlphabet
{
    public static class Translator
    {
        public static bool TryTranslateToMorseCode(char @char, out byte @byte)
        {
            @byte = 0b00000000;

            switch (@char)
            {
                case 'A':
                case 'a':
                    @byte = 0b0011_0001;
                    break;

                // TODO #1. Analyze the method unit tests and implement the method.
            }

            return true;
        }

        public static bool TryTranslateFromMorse(byte @byte, out char @char)
        {
            @char = ' ';

            switch (@byte)
            {
                case 0b0011_0001:
                    @char = 'A';
                    break;

                // TODO #2. Analyze the method unit tests and implement the method.
            }

            return true;
        }
    }
}
