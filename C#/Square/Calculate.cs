namespace Square
{
    public static class Calculate
    {
        /// <summary>
        ///  Выполнение без знания типа фигуры в compile-time.
        /// </summary>
        /// <param name="figure">фигура, для которой нужно посчитать площадь</param>
        public static void CalculateArea(Figure figure)
        {
            Console.WriteLine($"площадь фигуры {figure.Name} = {figure.GetAreaShape()}");
            if (figure is Triangle) {
                var item = ((ITrinagle)figure).IsRectangular();
                Console.WriteLine($"Треугольник " + (item ? "прямоугольный" : "непрямоугольный"));
            }}
    }
}
