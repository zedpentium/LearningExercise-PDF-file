using System;

namespace LearningExercise_PDF_file
{
    class Program
    {
        static void Main(string[] args)
        {
            var keepAlive = true;
            while (keepAlive)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("----* Welcome to Eric R's Learning Exercise PDF program *----\n");
                    Console.WriteLine("Choose function:\n");
                    Console.WriteLine("1) Run Exercise 1");
                    Console.WriteLine("2) Run Exercise 2");
                    Console.WriteLine("3) Run Exercise 3");
                    Console.WriteLine("4) Run Exercise 4");
                    Console.WriteLine("5) Run Exercise 5");
                    Console.WriteLine("6) Run Exercise 6");
                    Console.WriteLine("7) Run Exercise 7");
                    Console.WriteLine("8) Run Exercise 8");
                    Console.WriteLine("9) Run Exercise 9");
                    Console.WriteLine("10) Run Exercise 10");
                    Console.WriteLine("11) Run Exercise 11");
                    Console.WriteLine("12) Run Exercise 12");
                    Console.WriteLine("13) Run Exercise 13");
                    Console.WriteLine("14) Run Exercise 14");
                    Console.WriteLine("15) Run Exercise 15");
                    Console.WriteLine("-1) Quit program");

                    Console.WriteLine("\nType in a number from the menu & press enter: ");

                    var assignmentChoice = int.Parse(Console.ReadLine() ?? "");
                    Console.ForegroundColor = ConsoleColor.Green;
                    switch (assignmentChoice)
                    {
                        case 1:
                            RunExerciseOne();
                            break;
                        case 2:
                            RunExerciseTwo();
                            break;
                        case 3:
                            RunExerciseThree();
                            break;
                        case 4:
                            RunExerciseFour();
                            break;
                        case 5:
                            RunExerciseFive();
                            break;
                        case 6:
                            RunExercise6();
                            break;
                        case 7:
                            RunExercise7();
                            break;
                       /* case 8:
                            RunExercise8();
                            break;
                        case 9:
                            RunExercise9();
                            break;
                        case 10:
                            RunExercise10();
                            break;
                        case 11:
                            RunExercise11();
                            break;
                        case 12:
                            RunExercise12();
                            break;
                        case 13:
                            RunExercise13();
                            break;
                        case 14:
                            RunExercise14();
                            break;
                        case 15:
                            RunExercise15();
                            break; */
                        case -1:
                            keepAlive = false;
                            Environment.Exit(0); // added to quicker finish program and nto have "Hit key to continue" before quit
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is not a valid assignment number!");
                            break;
                    }
                    Console.ResetColor();
                    Console.WriteLine("Hit any key to continue!");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid assignment number!");
                    Console.ResetColor();
                }
            }
        }

        private static void RunExerciseOne()
        {
            string sFirstName = "Eric";
            string sLastName = "Rönnhult";

            Console.Clear();
            Console.WriteLine($"Hello {sFirstName} {sLastName}! I’m glad to inform you that you are the test subject of my very first assignment!");

            //Console.WriteLine("You sucessfully ran excercise one!");
        }

        private static void RunExerciseTwo()
        {
            DateTime vToday = DateTime.Today;
            DateTime vTomorrow = DateTime.Today.AddDays(+1);
            DateTime vYesterday = DateTime.Today.AddDays(-1);

            Console.Clear();
            Console.WriteLine($"Todays date is {vToday.ToString("yyyy/MM/dd")}\n\n");
            Console.WriteLine($"Tomorrows date is {vTomorrow.ToString("yyyy/MM/dd")}\n\n");
            Console.WriteLine($"Yesterdays date was {vYesterday.ToString("yyyy/MM/dd")}\n\n");

            //Console.WriteLine("You sucessfully ran excercise two!");
        }

        private static void RunExerciseThree()
        {

            Console.Clear();

            Console.Write("Enter your first name: ");
            string sFirstName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            string sLastName = Console.ReadLine();

            Console.WriteLine($"\n\n{sFirstName} {sLastName}\n\n");
        }

        private static void RunExerciseFour()
        {

            Console.Clear();

            /* Final output to screen:
            The brown fox jumped over the lazy dog
            */

            string str = "The quick fox Jumped Over the DOG";
            string strOutput = ""; // As stated in exercise PDF, and empty string

            // this is output info of what the string "str" contain
            Console.WriteLine($"Here is the str string variable:\n{str}\n");

            // start of string manipulation
            strOutput = str.Replace("quick", "brown");

            int strIndexOf = strOutput.IndexOf("Jumped");

            string strSubWord = strOutput.Substring(strIndexOf, 6);

            strOutput = strOutput.Replace(strSubWord, "jumped");

            strOutput = strOutput.Replace("Over", "over");

            strIndexOf = strOutput.IndexOf("DOG");

            strOutput = strOutput.Insert(strIndexOf, "lazy ");

            strIndexOf = strOutput.IndexOf("DOG");

            Console.WriteLine($"And here is the output after all string manipulation:\n{strOutput.Remove(strIndexOf)}dog\n");
        }

        private static void RunExerciseFive()
        {
            Console.Clear();

            // Final output to screen must be [1,4,5,6,7,8,9,10]

            string str = "Arrays are very common in programming, they look something like: [1,2,3,4,5]";

            Console.WriteLine($"Here is the given string:\n{str}\n\n");

            int strIndexOf1 = str.IndexOf("[");
            int strIndexOf2 = str.IndexOf("]") + 1;

            string strNrPart = str.Substring(strIndexOf1, (strIndexOf2 - strIndexOf1));

            strIndexOf1 = strNrPart.IndexOf(",2,3");

            string strRemove = strNrPart.Remove(strIndexOf1, 4);

            strIndexOf1 = strRemove.IndexOf("5") + 1;

            string strOutput = strRemove.Insert(strIndexOf1, ",6,7,8,9,10");

            Console.WriteLine($"Output after string manipulation: {strOutput}");

        }

        private static void RunExercise6()
        {
            // Decl of variables
            int int1;
            int int2;
            int intBig;
            int intSmall;
            int intDif;
            int intSum;
            int intProd;
            int intRat;
            string str1;
            string str2;

            Console.Clear();
            Console.Write("Input 2 integers, output biggest, smallers, difference -, sum +, product * and ratio /.\n\n");
            Console.Write("Enter first integer: ");
            str1 = Console.ReadLine();
            Int32.TryParse(str1, out int1);

            Console.Write("Enter second integer: ");
            str2 = Console.ReadLine();
            Int32.TryParse(str2, out int2);



            Console.WriteLine($"\nOutput result of {int1} & {int2}");
            if (int1 > int2)
                {
                intBig = int1;
                intSmall = int2;
                }
            else
                {
                intBig = int2;
                intSmall = int1;
                }
            Console.WriteLine($"\n\nBiggest: {intBig}");
            Console.WriteLine($"Smallest: {intSmall}");

            intDif = int1 - int2;
            Console.WriteLine($"Difference (-): {intDif}");
            intSum = int1 + int2;
            Console.WriteLine($"Sum (+): {intSum}");
            intProd = int1 * int2;
            Console.WriteLine($"Product (*): {intProd}");
            intRat = int1 / int2;
            Console.WriteLine($"Ratio (/): {intRat}");
        }

        private static void RunExercise7()
        {

        }
    }
}

