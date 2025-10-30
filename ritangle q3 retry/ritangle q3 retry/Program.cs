namespace ritangle_q3_retry
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int TotalOptions = 0;
            int divisibleBy25 = 0;

            for (int i = 111111; i <= 666666; i++)
            {
                string StringI = Convert.ToString(i);
                if (StringI.Contains('0') || StringI.Contains('7') || StringI.Contains('8') || StringI.Contains('9')) continue;

                TotalOptions++;
                if (i % 25 == 0)
                {
                    divisibleBy25++;
                }
            }

            if (TotalOptions == 0)
            {
                Console.WriteLine("No valid options found.");
                return;
            }

            float probability = (float)divisibleBy25 / TotalOptions * 100.0f;
            Console.WriteLine($"Probability: {probability}%");
        }
    }


}
