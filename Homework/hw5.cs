using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double rho;
            Console.WriteLine("By straightforward method "+ straightforward());
            Console.WriteLine("By BoxMuller method " + BoxMuller());
            Console.WriteLine("By Polar Rejection method " + PolarRejection());
            Console.WriteLine("Please input rho between -1 and 1:");
            rho = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("random variables that are joint normally distributed "+ Joint(rho));
            Console.ReadLine();

        }

        static double straightforward()
        {
            Random rnd = new Random();
            double randn;
            double n;
            n = 0;
            for(int a=1;a<13;a++)
            {
                randn = rnd.NextDouble();
                n = n + randn;
            }
            n = n-6;

            return n;
        }

        static Tuple<double, double> BoxMuller()
        {
            Random rnd = new Random();
            double randn1;
            double randn2;
            double z1;
            double z2;
            randn1 = rnd.NextDouble();
            randn2 = rnd.NextDouble();
            z1 = Math.Sqrt(-2 * Math.Log(randn1)) * Math.Cos(2 * Math.PI * randn2);
            z2 = Math.Sqrt(-2 * Math.Log(randn1)) * Math.Sin(2 * Math.PI * randn2);
            Tuple<double, double> y = new Tuple<double, double>(z1, z2); 
            return y;
        }

        static Tuple<double,double> PolarRejection()
        {
            Random rnd = new Random();
            double randn1;
            double randn2;
            double w;
            double c;
            double z1;
            double z2;
            randn1 = 2 * rnd.NextDouble() - 1;
            randn2 = 2 * rnd.NextDouble() - 1;
            w = Math.Pow(randn1, 2) + Math.Pow(randn2, 2);
            while (w>1)
            {
                randn1 = 2 * rnd.NextDouble() - 1;
                randn2 = 2 * rnd.NextDouble() - 1;
                w = Math.Pow(randn1, 2) + Math.Pow(randn2, 2);
            }
            c = Math.Sqrt(-2 * Math.Log(w) / w);
            z1 = c * randn1;
            z2 = c * randn2;

            Tuple<double, double> y= new Tuple<double, double>(z1, z2);
            return y;
        }

        static Tuple<double, double> Joint(double rho)
        {
            Random rnd = new Random();
            double randn1;
            double randn2;
            double w;
            double c;
            double z1;
            double z2;
            randn1 = 2 * rnd.NextDouble() - 1;
            randn2 = 2 * rnd.NextDouble() - 1;
            w = Math.Pow(randn1, 2) + Math.Pow(randn2, 2);
            while (w > 1)
            {
                randn1 = 2 * rnd.NextDouble() - 1;
                randn2 = 2 * rnd.NextDouble() - 1;
                w = Math.Pow(randn1, 2) + Math.Pow(randn2, 2);
            }
            c = Math.Sqrt(-2 * Math.Log(w) / w);
            z1 = c * randn1;
            z2 = c * randn2;
            z2 = rho * z1 + Math.Sqrt(1 - Math.Pow(rho, 2)) * z2;

            Tuple<double, double> y = new Tuple<double, double>(z1, z2);
            return y;
        }


    }
}
