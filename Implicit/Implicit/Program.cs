using System;

namespace Implicit
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Celsius celsius = new Celsius(0);
            Kelvin kelvin = celsius;
            Console.WriteLine(kelvin.Degree);



    }
    }
        class Kelvin
        {
            public double Degree { get; set; }
            public Kelvin(double K)
            {
                Degree = K;
            }

        
    }
        class Celsius
        {
            public double Degree { get; set; }
            public Celsius(double C)
            {
                Degree = C;

            }
        

        public static implicit operator Kelvin(Celsius celsius)
        {
            return new Kelvin(celsius.Degree+273);
        }
    }

    }

