namespace right_angle_triangle_problem_brute_forcer
{
    internal class Program
    {
        static bool IsRightAngled(decimal xa, decimal ya, decimal xb, decimal yb, decimal xc, decimal yc)
        {
            decimal ABpwr2 = (xb - xa) * (xb - xa) + (yb - ya) * (yb - ya);
            decimal BCpwr2 = (xc - xb) * (xc - xb) + (yc - yb) * (yc - yb);
            decimal CApwr2 = (xa - xc) * (xa - xc) + (ya - yc) * (ya - yc);
            if (ABpwr2 + BCpwr2 == CApwr2 ||
                ABpwr2 + CApwr2 == BCpwr2 ||
                BCpwr2 + CApwr2 == ABpwr2)
            {
                return true;
            }
            return false;

        }
        static void Main()
        {
            decimal XA = 1m;
            decimal YA = 3m;
            decimal XB = -2m;
            decimal YB = 4m;
            decimal XC = 3m;
            decimal YC = -5m;
            for (decimal i = 0m; i < 1000000000; i++)
            {
                decimal NewXA = XA + 10 - (i / 1000000);
                bool FoundRightAngled = IsRightAngled(NewXA, YA, XB, YB, XC, YC);
                if (FoundRightAngled)
                {
                    Console.WriteLine($"Found right angled triangle with coordinates A({NewXA}, {YA}), B({XB}, {YB}), C({XC}, {YC})");
                }
            }
            for (decimal i = 0m; i < 1000000000; i++)
            {
                decimal NewYA = YA + 10 - (i / 1000000);
                bool FoundRightAngled = IsRightAngled(XA, NewYA, XB, YB, XC, YC);
                if (FoundRightAngled)
                {
                    Console.WriteLine($"Found right angled triangle with coordinates A({XA}, {NewYA}), B({XB}, {YB}), C({XC}, {YC})");
                }
            }


            for (decimal i = 0m; i < 1000000000; i++)
            {
                decimal NewXB = XB + 10 - (i / 1000000);
                bool FoundRightAngled = IsRightAngled(XA, YA, NewXB, YB, XC, YC);
                if (FoundRightAngled)
                {
                    Console.WriteLine($"Found right angled triangle with coordinates A({XA}, {YA}), B({NewXB}, {YB}), C({XC}, {YC})");
                }
            }
            for (decimal i = 0m; i < 1000000000; i++)
            {
                decimal NewYB = YB + 10 - (i / 1000000);
                bool FoundRightAngled = IsRightAngled(XA, YA, XB, NewYB, XC, YC);
                if (FoundRightAngled)
                {
                    Console.WriteLine($"Found right angled triangle with coordinates A({XA}, {YA}), B({XB}, {NewYB}), C({XC}, {YC})");
                }
            }

            for (decimal i = 0m; i < 1000000000; i++)
            {
                decimal NewXC = XC + 10 - (i / 1000000);
                bool FoundRightAngled = IsRightAngled(XA, YA, XB, YB, NewXC, YC);
                if (FoundRightAngled)
                {
                    Console.WriteLine($"Found right angled triangle with coordinates A({XA}, {YA}), B({XB}, {YB}), C({NewXC}, {YC})");
                }
            }
            for (decimal i = 0m; i < 1000000000; i++)
            {
                decimal NewYC = YC + 10 - (i / 1000000);
                bool FoundRightAngled = IsRightAngled(XA, YA, XB, YB, XC, NewYC);
                if (FoundRightAngled)
                {
                    Console.WriteLine($"Found right angled triangle with coordinates A({XA}, {YA}), B({XB}, {YB}), C({XC}, {NewYC})");
                }
            }
        }
    }
}
