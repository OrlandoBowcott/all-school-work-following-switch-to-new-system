namespace right_angle_triangle_problem_brute_forcer
{
    public class Triangle
    {
        public decimal XA { get; set; }
        public decimal YA { get; set; }
        public decimal XB { get; set; }
        public decimal YB { get; set; }
        public decimal XC { get; set; }
        public decimal YC { get; set; }
    }
    internal class Program
    {
        static 
        static void Main()
        {
            decimal XA = 1m;
            decimal YA = 3m;
            decimal XB = -2m;
            decimal YB = 4m;
            decimal XC = 3m;
            decimal YC = -5m;
            var RightAngled = new List<Triangle>();
            {
                Console.WriteLine($"Found right angled triangle with coordinates A({NewXA}, {YA}), B({XB}, {YB}), C({XC}, {YC})");

                Triangle tri = new Triangle()
                {
                    XA = NewXA,
                    YA = YA,
                    XB = XB,
                    YB = YB,
                    XC = XC,
                    YC = YC
                };
                RightAngled.Add(tri);
            }

        }
    }
}
