using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        private static double test1, test2, assignment, project, result;

        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                DisplayHeader();
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add Marks");
                Console.WriteLine("2. Check Marks");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Select an option (1-3):");

                if (Enum.TryParse(Console.ReadLine(), out MenuOption option))
                {
                    Console.Clear();

                    switch (option)
                    {
                        case MenuOption.AddMarks:
                            AddMarks();
                            CalculateResult();
                            break;
                        case MenuOption.CheckMarks:
                            CheckMarks();
                            break;
                        case MenuOption.Exit:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid option, please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter a number between 1 and 3.");
                }

                if (!exit)
                {
                    Console.WriteLine("\nPress any key to return to the menu...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        enum MenuOption
        {
            AddMarks = 1,
            CheckMarks,
            Exit
        }

        static void DisplayHeader()
        {
            Console.Clear();
            Console.WriteLine("********************************************");
            Console.WriteLine("           Grade Calculation System         ");
            Console.WriteLine("********************************************");
            Console.WriteLine();
        }

        static void AddMarks()
        {
            test1 = GetMark("Test 1");
            test2 = GetMark("Test 2");
            assignment = GetMark("Assignment");
            project = GetMark("Project");
        }

        static double GetMark(string testName)
        {
            Console.WriteLine($"Enter your mark for {testName}:");
            double mark = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            return mark;
        }

        static void CalculateResult()
        {
            test1 = test1 / 100 * 30;
            test2 = test2 / 100 * 50;
            assignment = assignment / 100 * 10;
            project = project / 100 * 10;
            result = test1 + test2 + assignment + project;
        }

        static void CheckMarks()
        {
            Console.WriteLine("********************************************");
            Console.WriteLine($"Test 1 Mark: {test1:F2}");
            Console.WriteLine($"Test 2 Mark: {test2:F2}");
            Console.WriteLine($"Assignment Mark: {assignment:F2}");
            Console.WriteLine($"Project Mark: {project:F2}");
            Console.WriteLine($"Overall Average: {result:F2}");
            Console.WriteLine("********************************************");
            
            if (result <= 49)
            {
                Console.WriteLine("You have do not exam permission.");
            }
            else
            {
                Console.WriteLine("You have exam permission.");
            }
        }
    }
}
