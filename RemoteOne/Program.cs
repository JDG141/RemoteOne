namespace RemoteOne
{
    class Program
    {
        enum daysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void days() {
            daysOfWeek myDay = daysOfWeek.Monday;
            Console.Write("Input what day you want to have a meeting on: ");
            string day = Console.ReadLine().Trim();
            string firstLetters = day.ToLower().Substring(0, 2); // Two characters from the start of the string
            switch (firstLetters)
            {
                case "mo":
                    myDay = daysOfWeek.Monday;
                    break;
                case "tu":
                    myDay = daysOfWeek.Tuesday;
                    break;
                case "we":
                    myDay = daysOfWeek.Wednesday;
                    break;
                case "th":
                    myDay = daysOfWeek.Thursday;
                    break;
                case "fr":
                    myDay = daysOfWeek.Friday;
                    break;
                case "sa":
                    myDay = daysOfWeek.Saturday;
                    break;
                // Don't need to check for "su" because it's the only one left
                default:
                    myDay = daysOfWeek.Sunday;
                    break;
            }

            Console.WriteLine($"The day you selected was {myDay}");
        }

        enum colorsOfRainbow
        {
            Red,
            Orange,
            Yellow,
            Green,
            Blue,
            Indigo,
            Violet
        }

        static void colors() {
            colorsOfRainbow myColor = colorsOfRainbow.Red;
            Console.Write("Input your favourite colour of the rainbow: ");
            string color = Console.ReadLine().Trim();
            string firstLetters = color.ToLower().Substring(0, 2); // Two characters from the start of the string
            switch (firstLetters)
            {
                case "re":
                    myColor = colorsOfRainbow.Red;
                    break;
                case "or":
                    myColor = colorsOfRainbow.Orange;
                    break;
                case "ye":
                    myColor = colorsOfRainbow.Yellow;
                    break;
                case "gr":
                    myColor = colorsOfRainbow.Green;
                    break;
                case "bl":
                    myColor = colorsOfRainbow.Blue;
                    break;
                case "in":
                    myColor = colorsOfRainbow.Indigo;
                    break;
                // Don't need to check for "vi" because it's the only one left
                default:
                    myColor = colorsOfRainbow.Violet;
                    break;
            }

            Console.WriteLine($"The colour you selected was {myColor}");
        }

        public static void Main(string[] args)
        {
            // days();
            colors();
        }
    }
}