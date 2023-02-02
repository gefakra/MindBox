using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square
{
    public interface ITrinagle
    {
        /// <summary>
        /// Дополнительный метод даёт возможность реализации проверки треугольника на прямоугольность.
        /// </summary>     
        public bool IsRectangular();
    }
}
