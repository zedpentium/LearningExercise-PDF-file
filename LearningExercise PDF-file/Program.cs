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
                    Console.WriteLine("1) Run Exercise One");
                    Console.WriteLine("2) Run Exercise Two");
                    Console.WriteLine("3) Run Exercise Three");
                    Console.WriteLine("4) Tom");
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
                            // call your assignment method here!
                            break;
                        case -1:
                            keepAlive = false;
                            Environment.Exit(0); // jag la till för snabbare avslut än att få "Hit key to continue" innan avslut
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
            
            Console.WriteLine("Enter your first name: ");
            string sFirstName = Console.ReadLine();

            Console.WriteLine("\nEnter your last name: ");
            string sLastName = Console.ReadLine();

            Console.WriteLine($"\n\n{sFirstName} {sLastName}\n\n");
        }

    }
}
