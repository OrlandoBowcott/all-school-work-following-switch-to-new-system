namespace sigma_ritangle_brute_force_mwahehehehe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] lettersValues = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
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
            string[] stringsarr = foundStrings.ToArray();
            for (int i = 0; i < stringsarr.Length; i++)
            {
                List<int> valuse = new List<int>();
                for (int j = 0; j < stringsarr[i].Length; j++)
                {
                    for (int selectletter = 0; selectletter < letters.Length; selectletter++)
                    {
                        if (stringsarr[i][j] == letters[selectletter])
                        {
                            valuse.Add(lettersValues[selectletter]);
                            for (int k = 0; k < valuse.Count - 1; k++)
                            {
                                Console.Write(valuse[k] + " + ");
                                if (k == 6)
                                {
                                    Console.Write("\n");
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Total loops: " + loops);
        }
    }
}
