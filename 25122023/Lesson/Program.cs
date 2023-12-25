using System;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //char[] charArr = { '4','A',')'};
            //char[] charArr = new char[5] { 'f','3','5','2','{'};
            //char[] charArr = new char[3];

            //charArr[0] = '4';
            //charArr[1] = 'A';
            //charArr[2] = '.';

            //int[] numbers = { 45, 1, 6, 45, 8, 3 };

            //int[,] multiDArray = { { 1, 4, 2 }, { 3, 6, 8 },{ 43, 5, 7 },{ 1, -35, -5 } };

            //Console.WriteLine(multiDArray[3,1]);

            //int[][] jaggedArray = new int[][] { new int[] { 1, 4, 6 }, new int[] { 10, 4, 5, 7 }, new int[] { 65 } };
            //Console.WriteLine(jaggedArray[0][2]);

           
            
            bool check = true;
            do
            {
                Console.WriteLine("1. Topla");
                Console.WriteLine("2. Cix");
                Console.WriteLine("3. Vur");
                Console.WriteLine("4. Bol");
                Console.WriteLine("0. Proqrami bitir");

                string opt = Console.ReadLine();

                switch (opt)
                {
                    case "1":
                        Console.WriteLine("toplama");
                        break;
                    case "2":
                        Console.WriteLine("Cixma");
                        break;
                    case "3":
                        Console.WriteLine("Vurma");
                        break;
                    case "4":
                        Console.WriteLine("Bolme");
                        break;
                    case "0":
                        Console.WriteLine("Proqram bitdi");
                        check = false;
                        break;
                    default:
                        Console.WriteLine("yanlis emeliyyat");
                        break;
                }

            } while (check);




        }
    }
}
