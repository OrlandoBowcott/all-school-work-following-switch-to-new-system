namespace sigma_ritangle_brute_force_mwahehehehe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] lettersValues = { 17, 8, 19, 0, 13, 6, 11, 4 };
            char[] lettersToUse = { 'r', 'i', 't', 'a', 'n', 'g', 'l', 'e' };
            int loops = 0;
            List<string> foundStrings = new List<string>();
            for (int pos1 = 0; pos1 < 8; pos1++)
            {
                for (int pos2 = 0; pos2 < 8; pos2++)
                {
                    for (int pos3 = 0; pos3 < 8; pos3++)
                    {
                        for (int pos4 = 0; pos4 < 8; pos4++)
                        {
                            for (int pos5 = 0; pos5 < 8; pos5++)
                            {
                                for (int pos6 = 0; pos6 < 8; pos6++)
                                {
                                    for (int pos7 = 0; pos7 < 8; pos7++)
                                    {
                                        for (int pos8 = 0; pos8 < 8; pos8++)
                                        {
                                            string currentString = lettersToUse[pos1].ToString() + lettersToUse[pos2].ToString() + lettersToUse[pos3].ToString() + lettersToUse[pos4].ToString() + lettersToUse[pos5].ToString() + lettersToUse[pos6].ToString() + lettersToUse[pos7].ToString() + lettersToUse[pos8].ToString();
                                            bool valid = true;
                                            for (int char1 = 0; char1 < 8; char1++)
                                            {
                                                for (int char2 = 0; char2 < 8; char2++)
                                                {
                                                    if (currentString[char1] == currentString[char2] && char1 != char2)
                                                    {
                                                        valid = false;
                                                    }

                                                }
                                            }
                                            if (valid)
                                            {
                                                foundStrings.Add(currentString);
                                                Console.WriteLine(currentString);
                                                loops++;
                                            }
                                        }
                                    }
                                }
                            }
                        }

                    }
                }
            }
            Console.WriteLine("Total loops: " + loops);
            string[] stringsarr = foundStrings.ToArray();
            int longestroute = 0;
            int shortestroute = int.MaxValue;
            string longestroutestring = "";
            string shortestroutestring = "";
            for (int i = 0; i < stringsarr.Length; i++)
            {
                int currentroutetotal = 0;
                for (int j = 0; j < 7; j++)
                {
                    char L1 = stringsarr[i][j];
                    char L2 = stringsarr[i][j + 1];
                    int value1 = 0;
                    int value2 = 0;
                    int wrapDiff = 0;
                    for (int k = 0; k < 8; k++)
                    {
                        if (L1 == lettersToUse[k])
                        {
                            value1 = lettersValues[k];
                            break;
                        }
                    }
                    for (int k = 0; k < 8; k++)
                    {
                        if (L2 == lettersToUse[k])
                        {
                            value2 = lettersValues[k];
                            break;
                        }
                    }
                    int difference = value1 - value2;
                    if (difference < 0)
                    {
                        difference = -difference;
                    }
                    if (value1 > value2)
                    {
                        wrapDiff = (26 - value1) + value2;
                    }
                    else if (value2 > value1)
                    {
                        wrapDiff = (26 - value2) + value1;
                    }
                    if ( difference <= wrapDiff)
                    {
                        currentroutetotal += difference;
                    }
                    if (wrapDiff < difference)
                    {
                        currentroutetotal += wrapDiff;
                    }
                }
                if (currentroutetotal > longestroute)
                {
                    longestroute = currentroutetotal;
                    longestroutestring = stringsarr[i];
                }
                if (currentroutetotal < shortestroute)
                {
                    shortestroute = currentroutetotal;
                    shortestroutestring = stringsarr[i];

                }
               
            }
            Console.WriteLine("Longest route: " + longestroute);
            Console.WriteLine("Route: " + longestroutestring);
            Console.WriteLine("Shortest route: " + shortestroute);
            Console.WriteLine("Route: " + shortestroutestring);
        }
    }
}