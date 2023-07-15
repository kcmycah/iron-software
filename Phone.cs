using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodingChallenge
{
    internal class Phone
    {
        // keypads
        static string[] letters = { "", "", "ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "WXYZ" };

        public static string OldPhonePad(string input)
        {
            string output = "";
         
            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (currentChar == '#')
                    break; // Exit the loop if we encounter the send button

                if (currentChar == '*')
                {
                    if (output.Length > 0)
                        output = output.Substring(0, output.Length - 1); // Remove the last character
                    continue;
                }

                if (Char.IsDigit(currentChar))
                {
                    int buttonNumber = int.Parse(currentChar.ToString());
                    int buttonPresses = 1;

                    // Count consecutive occurrences of the button number
                    while (i + 1 < input.Length && input[i + 1] == currentChar)
                    {
                        buttonPresses++;
                        i++;
                    }
                    char letter = letters[buttonNumber][buttonPresses - 1]; // finding the correct letter
                    output += letter;
                }
            }

            return output;
        }
    }
}
