using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square
{
    public class Triangle : Figure, ITrinagle
    {
        private double A { get; set; }
        private double B { get; set; }
        private double C { get; set; }       
        /// <summary>
        /// Треугольник.
        /// </summary>
        /// <param name="a">сторона А</param>
        /// <param name="b">сторона В </param>
        /// <param name="c">сторона С</param>
        public Triangle(double a,double b, double c)
        {
            A = a;
            B = b;   
            C = c;
            Name = "Треугольник";
        }
        /// <summary>
        /// Посщитать площать треугольника по трём сторанам.
        /// </summary>
        /// <returns>площадь треугольника</returns>
        public override double GetAreaShape()
        {
            var P = (A + B + C) / 2;            
            return Math.Sqrt(P*(P-A)*(P-B)*(P-C));
        }
        /// <summary>
        /// Проверка является ли треугольник прямоугольним.
        /// </summary>
        /// <returns> true - является, false - неявляется /// </returns>
        public bool IsRectangular() =>  Math.Pow(A,2)+Math.Pow(B,2) == Math.Pow(C,2)
            || Math.Pow(A, 2) + Math.Pow(C, 2) == Math.Pow(B, 2) 
            || Math.Pow(C, 2) + Math.Pow(B, 2) == Math.Pow(A, 2);
    }
}
