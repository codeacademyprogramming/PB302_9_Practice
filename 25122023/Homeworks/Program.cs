using System;

namespace Homeworks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1
            //Verilmiş yazıdan içində boşluqlar olmayan yeni bir yazı düzəltmək 

            //Console.WriteLine("Yazini daxiledin:");
            //string str = Console.ReadLine();
            //string newStr = "";

            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (str[i]!=' ')
            //    {
            //        newStr += str[i];
            //    }
            //}

            //Console.WriteLine(newStr);


            #endregion

            #region task2
            //Verilmiş ədədlər siyahısındaki verilmiş n ədədinin yerləşdiyi indexi tapan proqram

            //int[] numsArr = { 34, 34, 55, 54, 213, 467 };

            //int n = 467;
            //int wantedIndex = -1;

            //for (int i = 0; i < numsArr.Length; i++)
            //{
            //    if (numsArr[i] == n)
            //    {
            //        wantedIndex = i;
            //        break;
            //    }
            //}

            //Console.WriteLine(wantedIndex);
            #endregion

            #region task3
            //Verilmiş yazılar siyahısında verilmiş hərfdən neçə ədəd olduğunu tapan proqram

            //Console.WriteLine("Yazilarin sayi:");
            //string lengthStr = Console.ReadLine();
            //int length = Convert.ToInt32(lengthStr);
            //string[] strArr = new string[length];

            //for (int i = 0; i < strArr.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}Yazini daxil edin:");
            //    strArr[i] = Console.ReadLine();
            //}

            //Console.WriteLine("Axtarilan herfi daxil edin:");
            //string letterStr = Console.ReadLine();
            ////char letter = letterStr[0];
            //char letter = Convert.ToChar(letterStr);

            //int count = 0;

            //for (int i = 0; i < strArr.Length; i++)
            //{
            //    string str = strArr[i];

            //    for (int j = 0; j < str.Length; j++)
            //    {
            //        if (str[j] == letter) count++;
            //    }
            //}

            //Console.WriteLine(count);

            #endregion

            #region task4
            //Verilmiş yazının əvvəlindəki boşluqlar silinmiş bir string düzəldən proqram (Misalçün verilmiş yazı "   salam necesen?   "-dirsə yeni düzələcək string "salam necəsən?   " olmalıdır.

            //string str = "   salam   necesen   ";

            //string newStr = "";

            //int startIndex = 0;
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (str[i] != ' ')
            //    {
            //        startIndex = i;
            //        break;
            //    }
            //}

            //for (int i = startIndex; i < str.Length; i++)
            //{
            //    newStr += str[i];
            //}



            #endregion

            #region task5
            //Verilmiş 2 ədəd üzərində verilmiş simvola uyğun əməliyyat edən proqram.
            //Simvol +,-,* və ya / olmalıdır, əks halda simvolu yenidən daxil edilməsi istənilməlidir.
            //(Misaçün simvol * olarsa verilmiş 2 ədəd vurulacaq və nəticəsi göstəriləcək)


            //int num1 = 45;
            //int num2 = 0;
            //var r = num1 / num2;
            //Console.WriteLine(r);
            ////+,-,*,/
            //bool check = true;
            //double result = 0;
            //do
            //{
            //    Console.WriteLine("operatoru daxil et:");
            //    string mathOperatorStr = Console.ReadLine();
            //    char mathOperator = Convert.ToChar(mathOperatorStr);
            //    check = true;

            //    switch (mathOperator)
            //    {
            //        case '+':
            //            result = num1 + num2;
            //            break;
            //        case '-':
            //            result = num1 - num2;
            //            break;
            //        case '*':
            //            result = num1 * num2;
            //            break;
            //        case '/':
            //            if (num2 == 0)
            //            {
            //                Console.WriteLine("bolen 0 ola bilmez");
            //                break;
            //            }
            //            result = num1 / num2;
            //            break;
            //        default:
            //            Console.WriteLine("Simvol yanlisdir!");
            //            check = false;
            //            break;
            //    }
            //} while (!check);

            //Console.WriteLine(result);


            #endregion
        }
    }
}
