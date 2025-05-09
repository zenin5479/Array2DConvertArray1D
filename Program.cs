﻿using System;

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

      private static void ArrayConvertOne()
      {
         int row, column, i, j, k = 0;
         int[] array1D = new int[12];
         int[,] array2D = new int[12, 12];
         Console.WriteLine("Введите количество строк и столбцов");
         int.TryParse(Console.ReadLine(), out row);
         //row = Convert.ToInt32(Console.ReadLine());
         int.TryParse(Console.ReadLine(), out column);
         //column = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Введите элементы двумерного массива");
         for (i = 0; i < row; i++)
         {
            for (j = 0; j < column; j++)
            {
               int.TryParse(Console.ReadLine(), out array2D[i, j]);
               //array2D[i, j] = Convert.ToInt32(Console.ReadLine());
            }
         }

         Console.WriteLine("Двумерный массив:");
         for (i = 0; i < row; i++)
         {
            for (j = 0; j < column; j++)
            {
               //Console.WriteLine("[{0},{1}] = {2}", i, j, array2D[i, j]);
               Console.Write("[{0}]", array2D[i, j]);
            }

            Console.WriteLine();
         }

         Console.WriteLine("Одномерный массив:");
         for (i = 0; i < row; i++)
         {
            for (j = 0; j < column; j++)
            {
               array1D[k++] = array2D[i, j];
            }
         }

         for (i = 0; i < row * column; i++)
         {
            //Console.WriteLine("[{0}] = {1}", i, array1D[i]);
            Console.Write("[{0}]", array1D[i]);
         }
      }

      private static void ArrayConvertTwo()
      {
         // Создание 1D - массива из 2D - массива по столбцам
         // Создание двумерного массива из 2 строк и трех столбцов
         int[,] int2DArray = new int[2, 3];
         Console.WriteLine("Ввод элементов двумерного массива: ");
         for (int i = 0; i < 2; i++)
         {
            for (int j = 0; j < 3; j++)
            {
               int2DArray[i, j] = Convert.ToInt32(Console.ReadLine());
            }
         }
         int index = 0;
         // Получение количества строк двумерного массива
         int noOfRows = int2DArray.GetLength(0);
         // Получение количества столбцов двумерного массива
         int noOfColumns = int2DArray.GetLength(1);
         // Создание трехмерного массива путем умножения значений noOfRows и noOfColumns
         int[] oneDimensionalArray = new int[noOfRows * noOfColumns];

         // Присвоение элементов 1d-массиву из 2d-массива
         for (int y = 0; y < noOfColumns; y++)
         {
            for (int x = 0; x < noOfRows; x++)
            {
               oneDimensionalArray[index] = int2DArray[x, y];
               index++;
            }
         }
         // Печать элементов массива 1d
         Console.WriteLine("Элементы одномерного массива: ");
         foreach (int item in oneDimensionalArray)
         {
            Console.Write(item + " ");
         }
      }

      private static void ArrayConvertThree()
      {
         // Создание 1D - массива из 2D - массива по строкам
         // Создание двумерного массива из 2 строк и трех столбцов
         int[,] int2DArray = new int[2, 3];
         Console.WriteLine("Ввод элементов двумерного массива: ");
         for (int i = 0; i < 2; i++)
         {
            for (int j = 0; j < 3; j++)
            {
               int2DArray[i, j] = Convert.ToInt32(Console.ReadLine());
            }
         }
         int index = 0;
         // Получение количества строк двумерного массива
         int noOfRows = int2DArray.GetLength(0);
         // Получение количества столбцов двумерного массива
         int noOfColumns = int2DArray.GetLength(1);
         // Создание трехмерного массива путем умножения значений noOfRows и noOfColumns
         int[] oneDimensionalArray = new int[noOfRows * noOfColumns];

         // Присвоение элементов 1d-массиву из 2d-массива
         for (int y = 0; y < noOfRows; y++)
         {
            for (int x = 0; x < noOfColumns; x++)
            {
               oneDimensionalArray[index] = int2DArray[y, x];
               index++;
            }
         }
         // Печать элементов массива 1d
         Console.WriteLine("Элементы одномерного массива: ");
         foreach (int item in oneDimensionalArray)
         {
            Console.Write(item + " ");
         }
      }
   }
}