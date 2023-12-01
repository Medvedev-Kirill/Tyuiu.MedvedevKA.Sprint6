using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MedvedevKA.Sprint6.Task3.V22.Lib
{
    public class DataService : ISprint6Task3V22
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0)+1;

            for (int i = 0; i < rows; i++)
            {
                if (matrix[0, i] % 2 == 0)

                    matrix[0, i] = 0;

            }
            return matrix;
        }
    }
}
