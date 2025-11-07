using System.Security.Cryptography;

namespace clock_ritangle_question
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int hours = 0; hours < 12; hours++)
            {
                for (int minutes = 0; minutes < 60; minutes++)
                {
                    for (int seconds = 0; seconds < 60; seconds++)
                    {
                        double diffhourmin = 0;
                        double diffminsec = 0;
                        double diffsechour = 0;

                        double hoursangle = 360 / 12 * hours;
                        double minutesangle = 360 / 60 * minutes;
                        double secondsangle = 360 / 60 * seconds;
                        if (hoursangle - minutesangle < 180 && hoursangle - minutesangle >= 0)
                        {
                            diffhourmin = hoursangle - minutesangle;
                        }
                        else if (360 - (hoursangle - minutesangle) < 180 && 360 - (hoursangle - minutesangle) >= 0)
                        {
                            diffhourmin = 360 - (hoursangle - minutesangle);
                        }
                        else if (minutesangle - hoursangle < 180 && minutesangle - hoursangle >= 0)
                        {
                            diffhourmin = minutesangle - hoursangle;
                        }
                        else if (360 - (minutesangle - hoursangle) < 180 && 360 - (minutesangle - hoursangle) >= 0)
                        {
                            diffhourmin = 360 - (minutesangle - hoursangle);
                        }

                        if (minutes - secondsangle < 180 && minutesangle - secondsangle >= 0)
                        {
                            diffminsec = minutesangle - secondsangle;
                        }
                        else if (360 - (minutesangle - secondsangle) < 180 && 360 - (minutesangle - secondsangle) >= 0)
                        {
                            diffminsec = 360 - (minutesangle - secondsangle);
                        }
                        else if (secondsangle - minutesangle < 180 && secondsangle - minutesangle >= 0)
                        {
                            diffminsec = secondsangle - minutesangle;
                        }
                        else if (360 - (secondsangle - minutesangle) < 180 && 360 - (secondsangle - minutesangle) >= 0)
                        {
                            diffminsec = 360 - (secondsangle - minutesangle);
                        }

                        if (secondsangle - hoursangle < 180 && secondsangle - hoursangle >= 0)
                        {
                            diffsechour = secondsangle - hoursangle;
                        }
                        else if (360 - (secondsangle - hoursangle) < 180 && 360 - (secondsangle - hoursangle) >= 0)
                        {
                            diffsechour = 360 - (secondsangle - hoursangle);
                        }
                        else if (hoursangle - secondsangle < 180 && hoursangle - secondsangle >= 0)
                        {
                            diffsechour = hoursangle - secondsangle;
                        }
                        else if (360 - (hoursangle - secondsangle) < 180 && 360 - (hoursangle - secondsangle) >= 0)
                        {
                            diffsechour = 360 - (hoursangle - secondsangle);
                        }



                    }
                }
            }
        }
    }
}
