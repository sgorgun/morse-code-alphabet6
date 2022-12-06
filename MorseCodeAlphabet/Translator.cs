namespace MorseCodeAlphabet
{
    public static class Translator
    {
        public static bool TryTranslateToMorseCode(char @char, out byte @byte)
        {
            @byte = 0b00000000;

            switch (@char)
            {
                case 'A' or 'a':
                    @byte = 0b0011_0001;
                    break;
                case 'B' or 'b':
                    @byte = 0b1111_1110;
                    break;
                case 'C' or 'c':
                    @byte = 0b1111_1010;
                    break;
                case 'D' or 'd':
                    @byte = 0b0111_0110;
                    break;
                case 'E' or 'e':
                    @byte = 0b0001_0001;
                    break;
                case 'F' or 'f':
                    @byte = 0b1111_1011;
                    break;
                case 'G' or 'g':
                    @byte = 0b0111_0100;
                    break;
                case 'H' or 'h':
                    @byte = 0b1111_1111;
                    break;
                case 'I' or 'i':
                    @byte = 0b0011_0011;
                    break;
                case 'J' or 'j':
                    @byte = 0b1111_0001;
                    break;
                case 'K' or 'k':
                    @byte = 0b0111_0010;
                    break;
                case 'L' or 'l':
                    @byte = 0b1111_1101;
                    break;
                case 'M' or 'm':
                    @byte = 0b0011_0000;
                    break;
                case 'N' or 'n':
                    @byte = 0b0011_0010;
                    break;
                case 'O' or 'o':
                    @byte = 0b0111_0000;
                    break;
                case 'P' or 'p':
                    @byte = 0b1111_1001;
                    break;
                case 'Q' or 'q':
                    @byte = 0b1111_0100;
                    break;
                case 'R' or 'r':
                    @byte = 0b0111_0101;
                    break;
                case 'S' or 's':
                    @byte = 0b0111_0111;
                    break;
                case 'T' or 't':
                    @byte = 0b0001_0000;
                    break;
                case 'U' or 'u':
                    @byte = 0b0111_0011;
                    break;
                case 'V' or 'v':
                    @byte = 0b1111_0111;
                    break;
                case 'W' or 'w':
                    @byte = 0b0111_0001;
                    break;
                case 'X' or 'x':
                    @byte = 0b1111_0110;
                    break;
                case 'Y' or 'y':
                    @byte = 0b1111_0010;
                    break;
                case 'Z' or 'z':
                    @byte = 0b1111_1100;
                    break;
                default: return false;
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
                case 0b1111_1110:
                    @char = 'B';
                    break;
                case 0b1111_1010:
                    @char = 'C';
                    break;
                case 0b0111_0110:
                    @char = 'D';
                    break;
                case 0b0001_0001:
                    @char = 'E';
                    break;
                case 0b1111_1011:
                    @char = 'F';
                    break;
                case 0b0111_0100:
                    @char = 'G';
                    break;
                case 0b1111_1111:
                    @char = 'H';
                    break;
                case 0b0011_0011:
                    @char = 'I';
                    break;
                case 0b1111_0001:
                    @char = 'J';
                    break;
                case 0b0111_0010:
                    @char = 'K';
                    break;
                case 0b1111_1101:
                    @char = 'L';
                    break;
                case 0b0011_0000:
                    @char = 'M';
                    break;
                case 0b0011_0010:
                    @char = 'N';
                    break;
                case 0b0111_0000:
                    @char = 'O';
                    break;
                case 0b1111_1001:
                    @char = 'P';
                    break;
                case 0b1111_0100:
                    @char = 'Q';
                    break;
                case 0b0111_0101:
                    @char = 'R';
                    break;
                case 0b0111_0111:
                    @char = 'S';
                    break;
                case 0b0001_0000:
                    @char = 'T';
                    break;
                case 0b0111_0011:
                    @char = 'U';
                    break;
                case 0b1111_0111:
                    @char = 'V';
                    break;
                case 0b0111_0001:
                    @char = 'W';
                    break;
                case 0b1111_0110:
                    @char = 'X';
                    break;
                case 0b1111_0010:
                    @char = 'Y';
                    break;
                case 0b1111_1100:
                    @char = 'Z';
                    break;
                default: return false;
            }

            return true;
        }
    }
}
