
using System;

namespace ConsolApp
{
    class Program
    {
        static void Main( string[]args)
        {
            /*
        // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

        Console.WriteLine ("Введите число");

        string number = Console.ReadLine();
        
        if (number.Length < 3)
        {
            Console.WriteLine ("Третьей цифры нет");
        }
        else
        {
            Console.WriteLine ("Третья цифра " + number [2]);
        }
        */

        // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
        
        int day = 4;
        Day15Zadacha(day);
        day = 7;
        Day15Zadacha(day);
        Console.WriteLine ();
        Console.WriteLine ();
        void Day15Zadacha(int currentDay)
   
        {
            Console.WriteLine ("__________________");
            Console.WriteLine ("Задача 15");
            if (currentDay == 6 || currentDay == 7)
            {
                Console.WriteLine ("Выходной");
            }
            else
            {
                Console.WriteLine ("Рабочий день");
            }

        }






        }
    }
}



