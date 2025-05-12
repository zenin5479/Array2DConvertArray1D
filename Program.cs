using System;

namespace Array2DConvertArray1D
{
   internal class Program
   {
      static void Main()
      {
         int row;
         Console.WriteLine("Введите количество строк:");
         int.TryParse(Console.ReadLine(), out row);
         //row = Convert.ToInt32(Console.ReadLine());
         int column;
         Console.WriteLine("Введите количество столбцов:");
         int.TryParse(Console.ReadLine(), out column);
         //column = Convert.ToInt32(Console.ReadLine());
         int[,] array2D = new int[row, column];
         // Создание одномерного массива умножением строк и столбцов
         int[] array1D = new int[row * column];
         Console.WriteLine("Введите последовательно элементы двумерного массива:");
         for (int i = 0; i < row; i++)
         {
            for (int j = 0; j < column; j++)
            {
               int.TryParse(Console.ReadLine(), out array2D[i, j]);
               //array2D[i, j] = Convert.ToInt32(Console.ReadLine());
            }
         }

         Console.WriteLine("Двумерный массив:");
         for (int i = 0; i < row; i++)
         {
            for (int j = 0; j < column; j++)
            {
               //Console.WriteLine("[{0},{1}] = {2}", i, j, array2D[i, j]);
               Console.Write("[{0}]", array2D[i, j]);
            }

            Console.WriteLine();
         }

         Console.WriteLine("Одномерный массив созданный по строкам элементов двумерного массива:");
         int indexColumn = 0;
         for (int i = 0; i < row; i++)
         {
            for (int j = 0; j < column; j++)
            {
               array1D[indexColumn++] = array2D[i, j];
            }
         }

         for (int i = 0; i < row * column; i++)
         {
            //Console.WriteLine("[{0}] = {1}", i, array1D[i]);
            Console.Write("[{0}]", array1D[i]);
         }

         Console.WriteLine();

         Console.WriteLine("Одномерный массив созданный по столбцам элементов двумерного массива:");
         int indexRow = 0;
         for (int j = 0; j < column; j++)
         {
            for (int i = 0; i < row; i++)
            {
               array1D[indexRow++] = array2D[i, j];
            }
         }

         for (int i = 0; i < row * column; i++)
         {
            //Console.WriteLine("[{0}] = {1}", i, array1D[i]);
            Console.Write("[{0}]", array1D[i]);
         }

         //ArrayConvertOne();
         //ArrayConvertTwo();
         //ArrayConvertThree();

         Console.ReadLine();
      }
   }
}