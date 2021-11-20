using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("На прямоугольнике размера A x B будет размещено максимально возможное количество квадратов со стороной C (без наложений)");
            Console.Write("Введите положительное число А: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите положительное число B: ");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите положительное число C: ");
            int C = Convert.ToInt32(Console.ReadLine());
            int nA = 0;
            int nB = 0;
            int rA = 0;
            int rB = 0;
            int N = 0;

            if (C < A || C < B)
            {
                while (rA + C <= A)
                {
                    nA++;
                    rA += C;
                }
                while (rB + C <= B)
                {
                    nB++;
                    rB += C;
                }
                while (nA != 0)
                {
                    N += nB;
                    nA--;
                }
                Console.WriteLine();
                Console.WriteLine("Максимально возможное количество квадратов со стороной {0}, ", C);
                Console.WriteLine("которое можно разместить на прямоугольнике размера {0} x {1} составляет {2} шт.", A, B, N);
                Console.ReadLine();
            }
            else
                Console.WriteLine("На прямоугольнике размером {0} x {1} нельзя разместить без наложения квадрат со стороной {2}", A, B, C);
            Console.ReadLine();
        }
    }
}
