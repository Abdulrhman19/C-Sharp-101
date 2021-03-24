﻿using System;
namespace C_101
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Number of students: ");
            int numberOfStudents = int.Parse(Console.ReadLine());
            String[] names = new string[numberOfStudents];
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

            Console.WriteLine(); // Add a newline after the loop

            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine("Student ({0})", i + 1);
                printStudentDetail(names[i], marks[i]);
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

        static void printStudentDetail(String name, int mark)
        {
            Console.WriteLine("\t-Name: {0}", name);
            Console.WriteLine("\t-Grade: {0}", mark);
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