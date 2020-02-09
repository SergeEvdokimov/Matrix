using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Матрица
{
    class Matrix
    {
        public int[,] arr;
        public Matrix()
        {
            arr = new int[5, 5];
        }
        public Matrix(int min, int max)
        {
            arr = new int[5, 5];
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[i, j] = random.Next(min, max + 1);
                }
            }
        }
        public Matrix(int[,] array)
        {
            this.arr = array;
        }

        public string get_array()
        {
            string result = "";
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    result += arr[i, j] + " ";
                }
                result += "\n";
            }
            return result;

        }

    }
}
