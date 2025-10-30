
namespace MOARPOWERQ3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float TotalOptions = 0;
            float divisibleBy25 = 0;
            for (int i = 11111; i <= 66666; i++)
            {
                string StringI = Convert.ToString(i);
                if (StringI.Contains('0') || StringI.Contains('7') || StringI.Contains('8') || StringI.Contains('9')) 
                {
                    continue;
                };
                TotalOptions++;
                if (StringI.Contains('2') && StringI.Contains('5')) divisibleBy25++;
                
            }
            Console.WriteLine(divisibleBy25);
            Console.WriteLine(TotalOptions);
            float probability = (divisibleBy25 / TotalOptions) * 100;
            Console.WriteLine(probability);
        }
    }
}
