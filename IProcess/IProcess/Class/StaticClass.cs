using System;
using System.Collections.Generic;
using System.Text;

namespace IProcess.Class
{
    /*
     Static class cannot instantiated using a new keyword.
     a static class can only contain static members
     A static method can only contain static variables and can only access other static items.
     A static constructor in a non-static class runs only once when the class is instantiated for the first time
     A static constructor in a static class runs only once when any of its static members accessed for the first time
     It allows only a static constructor to be declared
     A Static class cannot be inherited.
         */
    public static class HeightConvertor
    {
        static HeightConvertor()
        {

        }
        public static string val = "string";
        public static double InchsToCentimeters(this string HeightInInchs)
        {
            double inchs = Double.Parse(HeightInInchs);
            double Centimeters = (inchs * 2.54);
            return Centimeters;
        }

        public static double CentimetesToInchs(string HeightInCentimeters)
        {
            double centimeters = Double.Parse(HeightInCentimeters);
            double Inchs = (centimeters / 2.54);
            return Inchs;
        }
    }
}
