namespace clock_ritangle_question
{
    public class time
    {
        public int hours { get; set; }
        public int minutes { get; set; }
        public int seconds { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            double currentlowesttimevalue = 0;
            for (int hours = 0; hours < 23; hours++)
            {
                for (int minutes = 0; minutes < 59; minutes++)
                {
                    for (int seconds = 0; seconds < 59; seconds++)
                    {
                        double diffhourmin = 0;
                        double diffminsec = 0;
                        double diffsechour = 0;
                        int analoguehours = hours;
                        if ((minutes - hours == seconds - minutes) && (minutes - hours != 0))
                        {
                            if (hours > 12)
                            {
                                analoguehours = hours - 12;
                            }

                            double hoursangle = (360.0 / 12) * (analoguehours % 12 + minutes / 60.0 + seconds / 3600.0);
                            double minutesangle = (360.0 / 60) * (minutes + seconds / 60.0);
                            double secondsangle = (360.0 / 60) * seconds;


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

                            if (minutesangle - secondsangle < 180 && minutesangle - secondsangle >= 0)
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


                            double totalangle = diffhourmin + diffminsec + diffsechour;
                            Console.WriteLine($"{hours}:{minutes}:{seconds} - Total Angle: {totalangle} degrees");
                            if (currentlowesttimevalue == 0)
                            {
                                currentlowesttimevalue = totalangle;
                            }
                            else if (totalangle < currentlowesttimevalue)
                            {
                                currentlowesttimevalue = totalangle;
                            }
                        }

                    }
                }
            }
            Console.WriteLine($"Lowest Total Angle: {currentlowesttimevalue} degrees");
        }
    }
}
