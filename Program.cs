using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "8757%TLSNRTI%TYSFX%YXJK[JI%YF%^YWFU%JPFP%JMY%SNTO";
            string decodedMessage = DecodeMessage(input);
            Console.WriteLine("Mensaje decodificado (con presunto error de espacio): " + decodedMessage);
            Console.WriteLine("Mensaje decodificado (sin presunto error de espacio): " + decodedMessage.Replace("%", " "));
            Console.ReadLine();
        }

        static string DecodeMessage(string input)
        {
            char[] charArray = input.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] != '%')
                {
                    int asciiValue = charArray[i] - 5;
                    charArray[i] = (char)asciiValue;
                }
            }
            Array.Reverse(charArray);
            string decodedMessage = new string(charArray);

            return decodedMessage;
        }
    }
}
