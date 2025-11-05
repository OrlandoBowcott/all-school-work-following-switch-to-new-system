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
        static bool withintolerance (decimal item1, decimal item2, decimal tolerance = 0.0000001m)
        {
            if (item1 - item2 < tolerance || item2 - item1 < tolerance)
            {
                return true;
            }
            return false;
        }
        static bool IsRightAngled(decimal xa, decimal ya, decimal xb, decimal yb, decimal xc, decimal yc)
        {
            decimal ABpwr2 = (xb - xa) * (xb - xa) + (yb - ya) * (yb - ya);
            decimal BCpwr2 = (xc - xb) * (xc - xb) + (yc - yb) * (yc - yb);
            decimal CApwr2 = (xa - xc) * (xa - xc) + (ya - yc) * (ya - yc);
            if (withintolerance(ABpwr2 + BCpwr2, CApwr2) ||
                withintolerance(ABpwr2 + CApwr2, BCpwr2) ||
                withintolerance(BCpwr2 + CApwr2, ABpwr2))
            {
                return true;
            }
            return false;

        }
        static decimal calculateArea(decimal xa, decimal ya, decimal xb, decimal yb, decimal xc, decimal yc)
        {
            decimal area = Math.Abs((xa * (yb - yc) + xb * (yc - ya) + xc * (ya - yb)) / 2);
            return area;
        }
        static void Main()
        {
            decimal XA = 1m;
            decimal YA = 3m;
            decimal XB = -2m;
            decimal YB = 4m;
            decimal XC = 3m;
            decimal YC = -5m;
            var RightAngled = new List<Triangle>();
            for (decimal i = 0m; i < 10000000m; i++)
            {
                decimal NewXA = XA + 100 - (i / 100000m);
                bool FoundRightAngled = IsRightAngled(NewXA, YA, XB, YB, XC, YC);
                if (FoundRightAngled)
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
            for (decimal i = 0m; i < 10000000m; i++)
            {
                decimal NewYA = YA + 100 - (i / 100000m);
                bool FoundRightAngled = IsRightAngled(XA, NewYA, XB, YB, XC, YC);
                if (FoundRightAngled)
                {
                    Console.WriteLine($"Found right angled triangle with coordinates A({XA}, {NewYA}), B({XB}, {YB}), C({XC}, {YC})");
                    Triangle tri = new Triangle()
                    {
                        XA = XA,
                        YA = NewYA,
                        XB = XB,
                        YB = YB,
                        XC = XC,
                        YC = YC
                    };
                    RightAngled.Add(tri);
                }
            }


            for (decimal i = 0m; i < 10000000m; i++)
            {
                decimal NewXB = XB + 100 - (i / 100000m);
                bool FoundRightAngled = IsRightAngled(XA, YA, NewXB, YB, XC, YC);
                if (FoundRightAngled)
                {
                    Console.WriteLine($"Found right angled triangle with coordinates A({XA}, {YA}), B({NewXB}, {YB}), C({XC}, {YC})");
                    Triangle tri = new Triangle()
                    {
                        XA = XA,
                        YA = YA,
                        XB = NewXB,
                        YB = YB,
                        XC = XC,
                        YC = YC
                    };
                    RightAngled.Add(tri);
                }
            }
            for (decimal i = 0m; i < 10000000m; i++)
            {
                decimal NewYB = YB + 100 - (i / 100000m);
                bool FoundRightAngled = IsRightAngled(XA, YA, XB, NewYB, XC, YC);
                if (FoundRightAngled)
                {
                    Console.WriteLine($"Found right angled triangle with coordinates A({XA}, {YA}), B({XB}, {NewYB}), C({XC}, {YC})");
                    Triangle tri = new Triangle()
                    {
                        XA = XA,
                        YA = YA,
                        XB = XB,
                        YB = NewYB,
                        XC = XC,
                        YC = YC,
                    };
                    RightAngled.Add(tri);

                }
            }

            for (decimal i = 0m; i < 10000000m; i++)
            {
                decimal NewXC = XC + 100 - (i / 100000m);
                bool FoundRightAngled = IsRightAngled(XA, YA, XB, YB, NewXC, YC);
                if (FoundRightAngled)
                {
                    Console.WriteLine($"Found right angled triangle with coordinates A({XA}, {YA}), B({XB}, {YB}), C({NewXC}, {YC})");
                    Triangle tri = new Triangle()
                    {
                        XA = XA,
                        YA = YA,
                        XB = XB,
                        YB = YB,
                        XC = NewXC,
                        YC = YC
                    };
                    RightAngled.Add(tri);
                }
            }
            for (decimal i = 0m; i < 10000000m; i++)
            {
                decimal NewYC = YC + 100 - (i / 100000m);
                bool FoundRightAngled = IsRightAngled(XA, YA, XB, YB, XC, NewYC);
                if (FoundRightAngled)
                {
                    Console.WriteLine($"Found right angled triangle with coordinates A({XA}, {YA}), B({XB}, {YB}), C({XC}, {NewYC})");

                    Triangle tri = new Triangle()
                    {
                        XA = XA,
                        YA = YA,
                        XB = XB,
                        YB = YB,
                        XC = XC,
                        YC = NewYC
                    };
                    RightAngled.Add(tri);
                }
            }
            RightAngled.ToArray();
            for (int i  = 0; i < RightAngled.Count; i++)
            {
                decimal area = calculateArea(RightAngled[i].XA, RightAngled[i].YA, RightAngled[i].XB, RightAngled[i].YB, RightAngled[i].XC, RightAngled[i].YC);
                Console.WriteLine($"Triangle {i + 1} area: {area}");
            }
        }
    }
}
