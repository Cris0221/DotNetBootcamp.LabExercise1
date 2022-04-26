using System;

namespace CSharp.LabExercise1
{
    internal class Program
    {

        static void Number1()
        {       
            do
            {
                Console.WriteLine("Welcome to the Area and Perimeter Calculator");
                Console.WriteLine(" ");
                Console.Write("Enter length: ");
                decimal Input1 = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Enter width: ");
                decimal Input2 = Convert.ToDecimal(Console.ReadLine());

                decimal Area= Input1 * Input2;
                decimal Perimeter= 2 * (Input1 + Input2);

                Console.WriteLine("Area: {0}", Area);
                Console.WriteLine("Perimeter: {0}", Perimeter);

                Console.WriteLine(" ");
                Console.Write("Continue? y/n: ");

            } while (Console.ReadLine().Equals("Y", StringComparison.InvariantCultureIgnoreCase));

            Console.Clear();

        }
        static void Number2()
        {
            Console.WriteLine("Welcome to the Letter Grade Calculator");
            Console.WriteLine(" ");
            do
            {
                Console.Write("Enter numerical grade: ");
                int GradeInput = Convert.ToInt32(Console.ReadLine());

                if (GradeInput >= 0 && GradeInput <60)
                {
                    Console.WriteLine("Letter grade: F");
                }
                else if (GradeInput >= 60 &&GradeInput <= 66)
                {
                    Console.WriteLine("Letter grade: D");
                }
                else if (GradeInput >= 67 &&GradeInput <= 79)
                {
                    Console.WriteLine("Letter grade: C");
                }
                else if (GradeInput >= 80 &&GradeInput <= 87)
                {
                    Console.WriteLine("Letter grade: B");
                }
                else if (GradeInput >= 88 &&GradeInput <= 100)
                {
                    Console.WriteLine("Letter grade: A");
                }
                else
                {
                    Console.WriteLine("invalid Grade Input");
                }

                Console.WriteLine(" ");
                Console.Write("Continue? y/n: ");
            } while (Console.ReadLine().Equals("Y", StringComparison.InvariantCultureIgnoreCase));

            Console.Clear();

        }
        static void Number3()
        {
            do
            {
                Console.WriteLine("Welcome to the Download Time Estimator");
                Console.WriteLine(" ");
                Console.WriteLine("This program calculates how long it will take to download a file with a 56k analog modem.");
                Console.WriteLine("\n");

                Console.Write("Enter a file size (MB): ");
                decimal Size = Convert.ToInt32(Console.ReadLine()) * 1024000;
                Console.WriteLine(" ");
                decimal Time = Size / (5200 * 3600);

                decimal RemainderTime = 1 - (Convert.ToInt32(Time) - Time);

                decimal HourTime = Time - RemainderTime;
                HourTime = Convert.ToInt32(HourTime);

                decimal MinuteTime = RemainderTime * 60;
                MinuteTime = Convert.ToInt32(MinuteTime);

                decimal SecondTime = ((RemainderTime * 60) - MinuteTime)*60;
                SecondTime = Convert.ToInt32(SecondTime);

                Console.WriteLine("A 56k modem will take {0} hours {1} minutes {2} seconds", HourTime, MinuteTime, SecondTime);

                Console.WriteLine(" ");
                Console.Write("Continue? y/n: ");
            } while (Console.ReadLine().Equals("Y", StringComparison.InvariantCultureIgnoreCase));

            Console.Clear();
        }
        static void Number4()
        {
            Console.Write("Enter square size: ");
            int i, j, size;
            size = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= size; i++)
            {
                for (j = 1; j <= size; j++)
                    Console.Write("*");
                    Console.Write("\n");
            }
        }
        static void Main(string[] args)
        {
            Number1();
            Number2();
            Number3();
            Number4();
        }
    }
}
