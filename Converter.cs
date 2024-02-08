    using System;

   namespace converter
   {
    public class converter
    {
        public static double ConvertToMilimeters(double inches)
        {
            return inches * 25.4;
        }

        public static double ConvertToCentimeters(double inches)
        {
            return inches * 2.54;
        }

        public static double ConvertToMeters(double inches)
        {
            return inches * 0.0254;
        }
    }
    
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length == 2)
            {
                Console.WriteLine("write: dotnet run <number> <-unit>");
                return;
            }

            if (args[1] != "-cm" && args[1] != "-m" && args[1] != "-mm")
            {
                Console.WriteLine("please write a valid unit: -cm, -m, -mm");
                Console.WriteLine("example: dotnet run 5 -cm");
                return;
            }

            
            if (!double.TryParse(args[0], out inches))
            {
                Console.WriteLine("please write a number.");
                return;
            }
    
            switch (args[1])
            {
                case "-mm":
                    result = Converter.ConvertToMillimeters(inches);
                    Console.WriteLine($"{result} mm");
                    break;
                case "-cm":
                    result = Converter.ConvertToCentimeters(inches);
                    Console.WriteLine($"{result} cm");
                    break;
                case "-m":
                    result = Converter.ConvertToMeters(inches);
                    Console.WriteLine($"{result} m");
                    break;
                default:
                    Console.WriteLine("Invalid unit. Please use -mm, -cm, or -m.");
                    break;
            }
        }
    }

   }