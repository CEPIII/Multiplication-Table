using System;

namespace MultiplicationTable
{
    class Program
    {    //MultiplicationTable  Universal. By two entered values
        static void Main(string[] args)
        {
            int x, y;
            string inputX, inputY;

            Console.WriteLine(@"Введите вертикальный параметр таблицы умножения ""X""= ");
            inputX = Console.ReadLine();
            Console.WriteLine($"X = {inputX}");
             
            Console.WriteLine(@"Введите вертикальный параметр таблицы умножения ""Y""= ");
            inputY = Console.ReadLine();
            Console.WriteLine($"X = {inputY}");
             
            x = Int32.Parse(inputX);
            y = Int32.Parse(inputY);

            int[,] arr = new int[x, y];
            //  Заполнить массив:
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    arr[i, j] = (i + 1) * (j + 1);
                }
            }
            //  Вывожу шапку таблицы
            for (int i = 1; i <= y; i++) Console.Write("\t" + i);
            Console.WriteLine();
            //  вывожу результаты вычислений таблицы, учитывая вертикальную "шапку"   
            for (int i = 0; i < x; i++)
            {
                Console.Write("\n" + (i + 1));
                for (int j = 0; j < y; j++)
                {
                    Console.Write("\t" + arr[i, j]);
                }
                Console.WriteLine();
            }
        }
    }

}
