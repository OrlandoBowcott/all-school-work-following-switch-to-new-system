using System;

namespace Q4_big_boi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer = "";
            for (int a = 0; a < 6; a++)
            {
                for (int b = 0; b < 6; b++)
                {
                    for (int c = 0; c < 6; c++)
                    {
                        for (int d = 0; d < 6; d++)
                        {
                            for (int e = 0; e < 6; e++)
                            {
                                if ( a == b || a == c || a == d || a == e ||
                                    b == c || b == d || b == e||
                                    c == d || c == e ||
                                    d == e)
                                {
                                    continue;
                                }
                                if (2025 == 5 * 15 * a + 5 * 15 * b + 5 * 27 * c + 5 * 27 + d + 15 * 27 * e)
                                {
                                    answer = Convert.ToString(a) + Convert.ToString(b) + Convert.ToString(c) + Convert.ToString(d) + Convert.ToString(e);
                                    Console.WriteLine($"5 * 15 * {a} + 5 * 15 * {b} + 5 * 27 * {c} + 5 * 27 + {d} + 15 * 27 * {e} = {5 * 15 * a + 5 * 15 * b + 5 * 27 * c + 5 * 27 + d + 15 * 27 * e}");
                                    Console.WriteLine(answer);

                                }
                            }
                        }
                    }
                }
            }
        }
    }
}