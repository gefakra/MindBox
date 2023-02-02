namespace Square
{    
    public class Circle : Figure
    {       
        private double Radius { get; set; }        
        /// <summary> Окружность </summary>
        /// <param name="radius">радиус окружности</param>
        public Circle(double radius) 
        {
            Radius= radius;
            Name = "Круг";
        }
        /// <summary>
        /// Посчитать площадь круга по радиусу.
        /// </summary>
        /// <returns> площадь круга  </returns>
        public override double GetAreaShape() => Math.PI* Math.Pow(this.Radius, 2);
    }
}