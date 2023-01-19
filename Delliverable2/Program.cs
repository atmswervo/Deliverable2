/*
Author: Adil Kedir
Date: 1/19/2023
Description: C# Console App
*/

namespace Deliverable_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a numeric grade value: ");

            try
            {
                int grade = int.Parse(Console.ReadLine());

                string letter;

                if (grade >= 90)
                {
                    letter = "A";
                    Console.WriteLine("Your expected letter grade in ISM 4300 is: " + letter);
                }

                else if (grade >= 80 && grade < 90)
                {
                    letter = "B";
                    Console.WriteLine("Your expected letter grade in ISM 4300 is: " + letter);
                }

                else if (grade >= 70 && grade < 80)
                {
                    letter = "C";
                    Console.WriteLine("Your expected letter grade in ISM 4300 is: " + letter);
                }

                else if (grade >= 60 && grade < 70)
                {
                    letter = "D";
                    Console.WriteLine("Your expected letter grade in ISM 4300 is: " + letter);
                }

                else if (grade >= 0 && grade < 60)
                {
                    letter = "F";
                    Console.WriteLine("You failed ISM 4300: " + letter);
                }

            } // end of try

            catch
            {
                Console.WriteLine("Enter numeric value: ");
            } // end of catch 

           
        }
    }
}


