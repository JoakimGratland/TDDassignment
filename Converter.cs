    using System;

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