/* Name: Stephanie McKenzie
 * Date: January 22, 2023
 * Description: C# App - ISM 4300 Letter-Grade Calculator 
 */


namespace Deliverable2_ConditionalStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {

//BEGINNING PROMPT

            Console.WriteLine("Please enter a numeric value: ");


//GRADE BREAKDOWN
            try
            {
                decimal grade = decimal.Parse(Console.ReadLine());
                if (grade >= 98)
                {
                    Console.WriteLine("Your expected letter grade for ISM4300 is a: A+");
                }
                else if (grade >= 92 && grade <= 97)
                {
                    Console.WriteLine("Your expected letter grade for ISM4300 is a: A");
                }
                else if (grade >= 90 && grade <= 91)
                {
                    Console.WriteLine("Your expected letter grade for ISM4300 is a: A-");
                }
                else if (grade >= 88 && grade <= 89)
                {
                    Console.WriteLine("Your expected letter grade for ISM4300 is a: B+");
                }
                else if (grade >= 82 && grade <= 87)
                {
                    Console.WriteLine("Your expected letter grade for ISM4300 is a: B");
                }
                else if (grade >= 80 && grade <= 81)
                {
                    Console.WriteLine("Your expected letter grade for ISM4300 is a: B-");
                }
                else if (grade >= 78 && grade <= 79)
                {
                    Console.WriteLine("Your expected letter grade for ISM4300 is a: C+");
                }
                else if (grade >= 72 && grade <= 77)
                {
                    Console.WriteLine("Your expected letter grade for ISM4300 is a: C");
                }
                else if (grade >= 70 && grade <= 71)
                {
                    Console.WriteLine("Your expected letter grade for ISM4300 is a: C-");
                }
                else if (grade >= 68 && grade <= 69)
                {
                    Console.WriteLine("Your expected letter grade for ISM4300 is a: D+");
                }
                else if (grade >= 62 && grade <= 67)
                {
                    Console.WriteLine("Your expected letter grade for ISM4300 is a: D");
                }
                else if (grade >= 60 && grade <= 61)
                {
                    Console.WriteLine("Your expected letter grade for ISM4300 is a: D-");
                }
                else if (grade < 60)
                {
                    Console.WriteLine("Greatest apologies, you have failed ISM4300.");
                }
            }
//ENDING PROMPT

            catch
            {

                Console.WriteLine("Please enter a numeric value: ");
            }
            //May the record show how much time I spent attempting a successful "try and catch" block.
            // :'(
        }
    }
}