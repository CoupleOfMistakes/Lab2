using System;

namespace Lab2
{
    class Program
    {


        static void ArrayNotEvenNumbers()
        {
            Console.WriteLine("Task 1.13\nChoose which array do u want to work with.\nThe \"1\" key means one-dimensional array.\nThe \"2\" key means two-dimensional array");
            string input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine("Input the size of your array: ");
                int array_size = int.Parse(Console.ReadLine());
                int[] array = new int[array_size];
                Console.WriteLine("Input the elements of your array: ");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine("Element " + i + " :");
                    array[i] = int.Parse(Console.ReadLine());
                }
                Console.Clear();
                Console.WriteLine("Your array: ");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine("[" + i + "] = " + array[i]);
                }
                Console.WriteLine("\nThe array without even numbers: ");
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0)
                    {
                        Console.WriteLine("[" + i + "] = " + array[i]);
                    }
                }
            }
            else if (input == "2")
            {
                Console.WriteLine("Input the size of your array (number of rows and columns): ");
                int array_row = int.Parse(Console.ReadLine());
                int array_column = int.Parse(Console.ReadLine());
                int[,] array = new int[array_row, array_column];
                Console.WriteLine("Input the elements of your array: ");
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.WriteLine("Element " + i + "," + j + " :");
                        array[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                Console.Clear();
                Console.WriteLine("Your array: ");
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.WriteLine("[" + i + "," + j + "] = " + array[i, j]);
                    }
                }
                Console.WriteLine("\nThe array without even numbers: ");
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (array[i, j] % 2 != 0)
                        {
                            Console.WriteLine("[" + i + "," + j + "] = " + array[i, j]);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("You've entered a wrong number. Try again");
            }
            Console.ReadLine();
        }
        static void ArrayMaxNegativeNumber()
        {
            Console.WriteLine("Task 2.13.\nInput the size of your array: ");
            int array_size = int.Parse(Console.ReadLine());
            double[] array = new double[array_size];
            Console.WriteLine("Input the elements of your array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Element " + i + " :");
                array[i] = double.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("Your array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("[" + i + "] = " + array[i]);
            }
            double max_negative_num = 0;
            bool isNegativeNumber = false;
            Console.WriteLine("Looking for max negative element... ");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < max_negative_num)
                {
                    max_negative_num = array[i];
                    isNegativeNumber = true;
                }
            }
            if (isNegativeNumber == true)
            {
                Console.WriteLine("There it is! Your number = " + max_negative_num);
            }
            else
            {
                Console.WriteLine("There's none :c ");
            }
            Console.ReadLine();
        }

        static void PrintArraySomeSpecialWay()
        {
            Console.WriteLine("Task 3.13.\nInput the size of your array n x n: ");
            int array_size = int.Parse(Console.ReadLine());
            int[,] array = new int[array_size, array_size];
            Console.WriteLine("Input the elements of your array: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine("Element " + i + "," + j + " :");
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Your array printed in some special way: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    if ((i + 1) % 2 != 0)
                    {
                        if (array[i, j] == array[i, array.GetLength(1) - 1])
                        {
                            Console.WriteLine("\n\t" + array[i, j]);
                        }
                        else
                        {
                            Console.Write(array[i, j] + "  ");
                        }
                    }

                    else if ((i + 1) % 2 == 0)
                    {
                        if (array[i, j] == array[i, array.GetLength(1) - 1])
                        {
                            Console.WriteLine("\n" + array[i, array.GetLength(1) - 1]);
                        }
                        else
                        {
                            Console.Write(array[i, array.GetLength(1) - 2 - j] + "  ");
                        }
                    }
                }
            }
            Console.ReadLine();
        }
        static void JaggedArrayFromSum()
        {
            Console.WriteLine("Task 4.13\nRandomizing elements in a jagged array...\nThe array now looks like this:");
            int size = 4;
            int[][] array = new int[size][];
            array[0] = new int[2];
            array[1] = new int[4];
            array[2] = new int[8];
            array[3] = new int[2];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = rand.Next(100);
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("A new array builded up from the sum of rows of the previous one: ");
            int[] new_array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    new_array[i] += array[i][j];
                }
                Console.Write(new_array[i] + " ");
            }
            int max = new_array[0];
            for (int i = 0; i < new_array.Length; i++)
            {
                if (max < new_array[i])
                {
                    max = new_array[i];
                }
            }
            Console.WriteLine("\nMax number in the new array is " + max);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\t\tLab 2\nThere are tasks with numbers 1.13, 2.13, 3.13, 4.13\nChoose the one you want to start:");
                String task_number = Console.ReadLine();
                switch (task_number)
                {
                    case "1.13": ArrayNotEvenNumbers(); break;
                    case "2.13": ArrayMaxNegativeNumber(); break;
                    case "3.13": PrintArraySomeSpecialWay(); break;
                    case "4.13": JaggedArrayFromSum(); break;
                    default: Console.WriteLine("You've chosen a wrong number. There is no such a task"); Console.ReadLine(); break;

                }
            }
        }
    }
}
