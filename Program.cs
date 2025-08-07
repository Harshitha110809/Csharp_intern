//using System;
//namespace program23
//{
//    class Discount
//    {
//        static void Main(string[] args)
//        {
//            float studentDiscount = 0, earlyDiscount = 0, discountedFee;
//            int discountPercent = 0;

//            Console.WriteLine("Enter the Name of the Student : ");
//            string name = Console.ReadLine();

//            Console.WriteLine("Enter the Actual Course Fee :");
//            float courseFee = float.Parse(Console.ReadLine());

//            Console.WriteLine("Enter the academic percentage of the student(%): ");
//            float academicScore = float.Parse(Console.ReadLine());

//            Console.Write("Enter day of registration (1-31): ");
//            int regDay = int.Parse(Console.ReadLine());


//            if (academicScore >= 90)
//            {
//                discountPercent = 30;
//                studentDiscount = 0.3f * courseFee;
//            }
//            else if (academicScore >= 75)
//            {
//                discountPercent = 20;
//                studentDiscount = 0.2f * courseFee;
//            }
//            else if (academicScore >= 60)
//            {
//                discountPercent = 10;
//                studentDiscount = 0.1f * courseFee;
//            }
//            else
//            {
//                discountPercent = 0;
//                studentDiscount = 0;
//            }

//            discountedFee = courseFee - studentDiscount;


//            if (regDay <= 15)
//            {
//                earlyDiscount = 0.05f * discountedFee;
//                discountedFee -= earlyDiscount;
//            }


//            Console.WriteLine("\n\t********* STUDENT DETAILS *********");
//            Console.WriteLine("\tStudent Name          : " + name);
//            Console.WriteLine("\tAcademic Percentage   : " + academicScore + "%");
//            Console.WriteLine("\tOriginal Course Fee   : " + courseFee);
//            Console.WriteLine("\tMerit Discount        : " + discountPercent + "%");
//            Console.WriteLine("\tMerit Discount Amount : " + studentDiscount);
//            if (earlyDiscount > 0)

//                Console.WriteLine("\tEarly Reg. Discount   : " + earlyDiscount);
//            else
//                Console.WriteLine("\tEarly Reg. Discount   : 0");
//            Console.WriteLine("\t-------------------------------");
//            Console.WriteLine("\n\tTotal Fee to be Paid  : " + discountedFee);
//        }
//    }
//}