using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool rpt = true;
            while (rpt)
            {
                menu();
                Console.WriteLine("For Exit Press 0");
                int reading = Convert.ToInt16(Console.ReadLine());
                if (reading == 0) rpt = false;
            }
            
            

        }
        static bool menu()
        {
            bool result = true;
            string mesaj; int fonk;
            Console.WriteLine("Enter a string message including multiple sentences.");
            mesaj = Console.ReadLine();
            Console.WriteLine("Choose one of the following 5 functions with 1-5 numbers in input.");
            fonk = Convert.ToInt16(Console.ReadLine());
            switch (fonk) {
                case 1:
                    Console.WriteLine(numberOfWords_1(mesaj));
                    break;
                case 2:
                    Console.WriteLine(numberOfSentences_2(mesaj));
                    break;
                case 3:
                    Console.WriteLine(avgNumberOfLetters_3(mesaj));
                    break;
                case 4:
                    Console.WriteLine(avgNumberofWords_4(mesaj));
                    break;
                case 5:
                    Console.WriteLine(mostRepeated_5(mesaj));
                    break;
                default:
                    Console.WriteLine("This is not a valid function!");
                    break;
            }

            return result;
        }


       
        static int numberOfWords_1(string input)
        {
            int counter = 0;
            for (int i =0;i<input.Length;i++) {
                if (input[i] == '.' || input[i] == '?' || input[i] == '!' || input[i] == ' ' || input[i] == ',') counter++;
            }

            return counter;
        }


       
        static int numberOfSentences_2(string input)
        {
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '.' || input[i] == '?' || input[i] == '!' ) counter++;
            }

            return counter;
        }


       
        static float avgNumberOfLetters_3(string input)
        {
            float avg = 0;
            int count = numberOfWords_1(input);
            avg =(input.Length-count)/count;
            return avg;

        }
        
        static float avgNumberofWords_4(string input)
        {
            float avg = 0;
            avg = numberOfWords_1(input) / numberOfSentences_2(input);
            return avg;

        }

        
        static string mostRepeated_5(string input)
        {
            int count = 0;
            int wordcount = 0;
            string result = string.Empty;
            input.Replace("?", " ");
            input.Replace("!", " ");
            input.Replace(".", " ");
            input.Replace(",", " ");

            string[] array = input.ToLower().Split(' ');
            for (int i=0;i<array.Length;i++)
            {
                for (int j =i+1;j<array.Length;j++)
                {
                    if (array[i]==array[j]) { count++; }

                }
                if (count > wordcount)
                {
                    wordcount = count;
                    result =array[i];

                }

            }


            
            return result;
        }

    }
}
