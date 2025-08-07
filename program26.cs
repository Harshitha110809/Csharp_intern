//using System;
//using System.Collections.Generic;
//namespace program25
//{
//    class VowelCount
//    {
//        static void Main(string[] args)
//        {
//            int n = 0;

//            Console.WriteLine("enter a valid word:");
//            string word = Console.ReadLine().ToLower();
//            if (!string.IsNullOrWhiteSpace(word))
//            {

//                foreach (int l in word)
//                {

//                    if (l == 'a' || l == 'e' || l == 'i' || l == 'o' || l == 'u')
//                    {
//                        n++;
//                    }
//                }
//                Console.WriteLine("number of vowels: " + n);
//            }
//            else
//            {
//                Console.WriteLine("invalid input");

//            }
//        }
//    }
//}