using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C6
{
    class Program
    {
        static void Main(string[] args)
        {
            int letterCount = 0;
            int vowelCount = 0;
            int consonantCount = 0;
            int syllableCount= 0;
            int musicalCount = 0;
            int letterDiff;
            bool increasing = true;
            bool secondHalf = true;
            bool alternating = true;
            bool smooth = true;
            bool ascending = false;
            bool descending = false;
            bool hills = false;

            char prevLetter = '0';

            while (true)
            {
                var keyInfo = Console.ReadKey();
                char letter = char.ToUpperInvariant(keyInfo.KeyChar);
                if (!char.IsLetter(letter)) break;

                letterCount += 1;

                bool vowels = letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U' || letter == 'Y';
                bool musical = letter == 'A' || letter == 'D' || letter == 'E' || letter == 'F' || letter == 'G' || letter == 'A' || letter == 'B';

                vowelCount = vowelCount + (vowels ? 1 : 0);
                musicalCount = musicalCount = (musical ? 1 : 0);

                if (vowels == false)
                {
                    consonantCount += 1;
                }

                if (vowels == true && prevLetter != 'A' && prevLetter != 'E' && prevLetter != 'I' && prevLetter != 'O' && prevLetter != 'U' && prevLetter !='Y')
                {
                    syllableCount += 1;
                }

                prevLetter = letter;

                if (letter < prevLetter || prevLetter == letter)
                {
                    increasing = false;
                }

                if (letter < 'M')
                {
                    secondHalf = false;
                }

                if (vowels == true && prevLetter == 'A' || prevLetter == 'E' || prevLetter == 'I' || prevLetter == 'O' || prevLetter == 'U' || prevLetter == 'Y')
                {
                    alternating = false;
                }

                letterDiff = Math.Abs(letter - prevLetter);
                if (letterDiff!=1 && letterDiff != 0)
                {
                    smooth = false;
                }

                if (letter > prevLetter)
                {
                    ascending = true;
                }
                else
                {
                    descending = true;
                }

                if (ascending == true && descending == false || ascending == false && descending == true)
                {
                    hills = true;
                }
                else
                {
                    hills = false;
                }

                descending = false;
                ascending = false;
            }

            Console.WriteLine("\n"+letterCount+" letters entered ");
            Console.WriteLine($"\n{vowelCount} vowels entered, {consonantCount} consonants entered.");
            Console.WriteLine($"There were {syllableCount} syllables entered."); //fails with words like 'squirreled' that have fewer syllables than vowels
            if (increasing == true)
            {
                Console.WriteLine("The letters were in increasing order.");
            }
            else
            {
                Console.WriteLine("The letters were not in increasing order.");
            }
            if (musicalCount == letterCount)
            {
                Console.WriteLine("All the letters can be played on a musical instrument.");
            }
            else
            {
                Console.WriteLine("All the letters can not be played on a musical instrument.");
            }
            if (secondHalf == true)
            {
                Console.WriteLine("All the letters are in the second half of the alphabet.");
            }
            else
            {
                Console.WriteLine("All the letters are not in the second half of the alphabet.");
            }
            if (alternating == true)
            {
                Console.WriteLine("All the letters alternate between consonants and vowels.");
            }
            else
            {
                Console.WriteLine("All the letters do not alternate between consonants and vowels.");
            }
            if (smooth == true)
            {
                Console.WriteLine("All the letters have smooth transitions.");
            }
            else
            {
                Console.WriteLine("All the letters do not have smooth transitions.");
            }
            if(hills == true)
            {
                Console.WriteLine("All the letters have alternating orders");
            }
            else
            {
                Console.WriteLine("All the letters do not have alternating orders");
            }
        
            Console.ReadKey();
        }
    }
}
