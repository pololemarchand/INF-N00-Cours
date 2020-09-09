using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPartie1
{
    public class Matrice
    {
        protected double[,] _mat;

        public Matrice(int n, int m)
        {
            _mat = new double[n, m];
        }

        public Boolean TestCarre()
        {
            if (_mat.GetUpperBound(0) == _mat.GetUpperBound(1))
                return true;
            else
                return false;
        }

        public void Affiche()
        {

            for (int i = 0; i <= _mat.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= _mat.GetUpperBound(1); j++)
                    Console.Write(_mat[i, j] + "\t");

                Console.WriteLine("");
            }
        }

        public void Transpose()
        {
            double[,]  transpose = new double[_mat.GetUpperBound(1)+1, _mat.GetUpperBound(0)+1];

            for (int i = 0; i <= _mat.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= _mat.GetUpperBound(1); j++)
                    transpose[j,i] = _mat[i, j];
            }
            _mat = transpose;
        }
    }

    public class MatriceAleatoire : Matrice
    {
        Random rnd = new Random();
        public MatriceAleatoire(int n, int m) : base(n,m)
        {
            for (int i = 0; i <= _mat.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= _mat.GetUpperBound(1); j++)
                {
                    base._mat[i, j] = rnd.Next(-10, 10);
                }
            }
        }
    }
    
}
