using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square
{
    public abstract class Figure
    {    
       /// <summary>
       /// Имя фигуры.
       /// </summary>
       public string Name { get; set; }

        /// <summary>
        /// Абстрактный метод подсчёта площади фигуры.
        /// </summary>        
       public abstract double GetAreaShape();
    }
}
