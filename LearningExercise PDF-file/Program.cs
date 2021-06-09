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
                    Console.WriteLine("----* Välkommen till Eric R's Learning Exercise PDF programmet *----\n");
                    Console.WriteLine("Välj funktion:");
                    Console.WriteLine();
                    Console.WriteLine("1) Run Exercise 1");
                    Console.WriteLine("2) Run Exercise 2");
                    Console.WriteLine("3) Run Exercise 3");
                    Console.WriteLine("4) Run Exercise 4");
                    Console.WriteLine("-1) Avsluta programmet");

                    Console.Write("\r\nSkriv in NR på menyval & tryck enter: ");
                    //Console.Write("Enter assignment number (or -1 to exit): ");

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

    }
}
