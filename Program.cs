using System;
namespace C_101
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Number of students: ");
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());
            string[] names = new string[numberOfStudents];
            int[] marks = new int[numberOfStudents];

            // 'numberOfStudents' must be a positive integer
            if (numberOfStudents > 0)
            {
                // Jump to 'createStudents()';
                createStudents(names, marks, numberOfStudents);
            }
            else
            {
                Console.WriteLine("You must have at least 1 student!");
            }

            Console.WriteLine();

            Console.WriteLine("++ Student Details ++");
            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine("Student ({0})", i + 1);
                printStudentDetails(names[i], marks[i]);
            }
        }

        static void createStudents(String[] names, int[] marks, int numberOfStudents)
        {
            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine("Student ({0})", i + 1);
                Console.Write("\t-Name: ");
                names[i] = Console.ReadLine();
                Console.Write("\t-Grade: ");
                marks[i] = int.Parse(Console.ReadLine());
            }
        }

        static void printStudentDetails(String name, int mark)
        {
            Console.WriteLine("\t-Name: {0}", name);
            Console.WriteLine("\t-Grade: {0}", mark);
            Console.WriteLine("\t-Passed or  Failed: {0}", checkStatus(mark));
            Console.WriteLine();    // Write a new empty line after each student
        }

        static string checkStatus(int mark)
        {
            if (mark >= 60)
            {
                return "Passed";
            }
            return "Failed";
        }
    }
}
