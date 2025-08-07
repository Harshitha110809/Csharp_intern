//using System;
//using System.Collections.Generic;
//namespace program25
//{
//    class VowelCount
//    {
//        static void Main(string[] args)
//        {
//            int n = 0;
//            List<int> count = new List<int>();
//            Console.WriteLine("enter a valid word:");
//            string word = Console.ReadLine().ToLower();
//            if (!string.IsNullOrWhiteSpace(word))
//            {

//                for (int i = 0; i < word.Length; i++)
//                {
//                    char l = word[i];
//                    if (l == 'a' || l == 'e' || l == 'i' || l == 'o' || l == 'u')
//                    {
//                        count.Add(i);
//                        n++;
//                    }
//                }
//                Console.WriteLine("number of vowels: " + n);
//                Console.WriteLine("Index of the vowels: " + string.Join(",", count));
//            }
//            else
//            {
//                Console.WriteLine("invalid input");

//            }
//        }
//    }
//}