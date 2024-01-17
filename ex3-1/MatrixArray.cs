using System;

namespace Arrays
{
    internal class MatrixArrray
    {
        public int[,] array;
        public MatrixArrray(int rows, int columns, bool IsUserInput = false)
        {
            if (IsUserInput)
            {
                this.array = this.UserFill(rows, columns);
            }
            else
            {
                this.array = this.RandomFill(rows, columns);
            }
        }
        public int[,] RandomFill(int rows, int columns)
        {
            Random random = new Random();
            int[,] array = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = random.Next(1, 1001);
                }
            }
            return array;
        }

        public int[,] UserFill(int rows, int columns)
        {
            int[,] array = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return array;
        }

        public void DisplayArray()
        {
            for (int i = 0; i < this.array.GetLength(0); i++)
            {
                for (int j = 0; j < this.array.GetLength(1); j++)
                {
                    string spaces = new string(' ', 5 - $"{this.array[i, j]}".Length);
                    Console.Write($"{spaces}{this.array[i, j]}");
                }
                Console.WriteLine(); 
            }
        }
    }
}
