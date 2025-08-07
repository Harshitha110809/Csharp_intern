using System;
using System.Linq;
namespace program32
{
    class StudentMark
    {
        static void Main(string[] args)
        {
            List<int> marks = new List<int>();
            List<int> newMarks = new List<int>();
            Console.Write("Enter how many marks you want to input: ");
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"enter marks {i+1} :");
                marks.Add(int.Parse(Console.ReadLine()));

            }
            Console.WriteLine("\t***ORIGINAL LIST OF MARKS***");
            foreach (int i in marks)
            {

                Console.WriteLine("\t" + i);

            }

            double average = marks.Average();
            Console.WriteLine($"\tTotal number of Marks entered : {n}\n\tAverage marks : {average}");
            Console.WriteLine("\n\t***Final List of Marks***");

            foreach (int i in marks)
            {
                if (i >= 35)
                {
                    newMarks.Add(i);
                    Console.WriteLine("\t" + i);
                }
            }
            double newAvg=newMarks.Average();
            int count=newMarks.Count();
            Console.WriteLine($"\tNew Count of Marks entered : {count}\n\tNew Average : {newAvg}");
            

        }
    }
}