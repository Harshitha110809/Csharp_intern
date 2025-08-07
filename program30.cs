//using System;
//using System.Linq;
//namespace program30
//{
//    class GreatestNum
//    {
//        static void Main(string[] args)
//        {
//            int[] numbers = new int[5];
//            int e=0,o = 0,regNo;
//            Console.WriteLine("Enter the Name of the student :");

//            string name = Console.ReadLine();
//            Console.WriteLine("Enter the regno. of the student :");
//            regNo = int.Parse(Console.ReadLine());

//            for (int i = 0; i < 5; i++)
//            {
//                Console.Write("Enter mark " + (i + 1) + ": ");
//                numbers[i] = int.Parse(Console.ReadLine());
//            }
           

//            Console.WriteLine("\t******STUDENT DETAILS******");
//            Console.WriteLine("\tStudent Name : "+name);
//            Console.WriteLine("\tStudent Reg No. : " + regNo);

//            double average = numbers.Sum();
//            Console.WriteLine("\tAverage of the student : " + average);

//            int maxValue = numbers.Max(); 
//            Console.WriteLine("\tHighest Score : " + maxValue);
            
        
//           Array.Reverse(numbers);
//            Console.Write("\tReverse order of the marks entered:");
//            foreach (int num in numbers)
//            {   if(num%2==0)
//                {
//                    e++;
//                }
//                else
//                {
//                    o++;
//                }
//                    Console.Write(num + " ");
//            }
//            Console.WriteLine($"\n\todd marks : {o}\n\teven marks : {e}");
//        }
//     }
//}