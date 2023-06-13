using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atempt_at_getting_matricies_to_work
{
    public class Matrix
    {
        private int rows;
        private int columns;
        private double[,] values;
        public Matrix(int x, int y)
        {
            rows = x;
            columns = y;
            values = new double[rows, columns];
        }
        public Matrix(double[,] values)
        {
            this.values = values;
            rows = values.GetLength(0);
            columns = values.GetLength(1);
        }
        public int GetRows()
        {
            return rows;
        }
        public int GetColumns()
        {
            return columns;
        }

        public static Matrix operator +(Matrix a)
        {
            return a;
        }
        public static Matrix operator -(Matrix a)
        {
            double[,] values = a.values;
            for (int i = 0; i < a.GetRows(); i++)
            {
                for (int j = 0; j < a.GetColumns(); j++)
                {
                    values[i, j] = -values[i, j];
                }
            }
            return new Matrix(values);
        }
        public static Matrix operator +(Matrix a, Matrix b)
        {
            double[,] values = a.values;
            for (int i = 0; i < a.GetRows(); i++)
            {
                for (int j = 0; j < a.GetColumns(); j++)
                {
                    values[i, j] += b.values[i, j];
                }
            }
            return new Matrix(values);
        }
        public static Matrix operator -(Matrix a, Matrix b)
        {
            return a + -b;
        }
        public static Matrix operator *(Matrix b, Matrix a)
        {
            double[,] values = new double[b.GetRows(), a.GetColumns()];

            for (int i = 0; i < b.GetRows(); i++)
            {
                for (int j = 0; j < a.GetColumns(); j++)
                {
                    double v = 0;
                    for (int k = 0; k < a.GetRows(); k++)
                    {
                        //Console.WriteLine($"i={i}, j={j}, k={k}");
                        v += a.values[k, j] * b.values[i, k];
                    }
                    values[i, j] = v;
                }
            }
            return new Matrix(values);
        }
        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < GetRows(); i++)
            {
                for (int j = 0; j < GetColumns(); j++)
                {
                    str += values[i, j];
                    str += ",\t";
                }
                str += "\n";
            }
            return str;
        }
        public Matrix Transpose()
        {
            double[,] v = new double[GetColumns(), GetRows()];
            for (int i = 0; i < GetRows(); i++)
            {
                for (int j = 0; j < GetColumns(); j++)
                {
                    v[j, i] = values[i, j];
                }
            }
            return new Matrix(v);
        }
        public static Matrix From1D(double[] array)
        {
            Matrix m = new Matrix(1, array.Length);

            for (int i = 0; i < array.Length; i++)
            {
                m.values[0, i] = array[i];
            }
            return m;
        }
        public double[] To1D()
        {
            double[] v = new double[GetColumns()];
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = values[0, i];
            }
            return v;
        }
        public double this[int row, int column] 
        {
            get { return values[row, column]; }
            set { values[row, column] = value;} 
        }
        public Matrix ApplyFunction(Func<double, double> func)
        {
            Matrix m = new Matrix(values);
            for (int i = 0; i < m.GetRows();i++)
            {
                for (int j = 0; j < m.GetColumns(); j++)
                {
                    m.values[i, j] = func(values[i, j]);
                }
            }
            return m;
        }
    }
}