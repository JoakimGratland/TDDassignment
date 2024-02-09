    using System;

   namespace ConverterProgram
   {
    public class Converter
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
            RunTests(args);

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

             if (args.Length == 3 && args[2] == "-t")
            {
                RunTests(args);
                return;
            }
            
            double inches;
            if (!double.TryParse(args[0], out inches))
            {
                Console.WriteLine("please write a number.");
                return;
            }

            double result = 0;
            switch (args[1])
           {
                case "-mm":
                    result = Converter.ConvertToMilimeters(inches);
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
    

    public static void RunTests(string[] args)
    {
        if (args.Length != 2)
        {
            Console.WriteLine("write: dotnet run <number> <-unit>");
            return;
        }
        double inches;
        if (!double.TryParse(args[0], out inches))
        {
            Console.WriteLine("please write a number.");
            return;
        }
        
        double expected = 0;
        switch (args[1])
        {
            case "-mm":
                expected = inches * 25.4;
                break;
            case "-cm":
                expected = inches * 2.54;
                break;
            case "-m":
                expected = inches * 0.0254;
                break;
            default:
                Console.WriteLine("Invalid unit. Please use -cm, -m, or -mm.");
                break;
        }

        double result = 0;
        switch (args[1])
        {
            case "-mm":
                result = Converter.ConvertToMilimeters(inches);
                break;
            case "-cm":
                result = Converter.ConvertToCentimeters(inches);
                break;
            case "-m":
                result = Converter.ConvertToMeters(inches);
                break;
            default:
                Console.WriteLine("Invalid unit. Please use -cm, -m, or -mm.");
                break;
        }
        Console.WriteLine($"Expected: {expected}");
        Console.WriteLine($"Received: {result}");
        if (result == expected)
        {
            Console.WriteLine("Test passed");
        }
        else
        {
            Console.WriteLine("Test failed");
        }

    }
    }
}