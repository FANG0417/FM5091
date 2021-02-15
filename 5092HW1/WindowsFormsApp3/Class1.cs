using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    //Create random number
    class RandomNumber
    {
        public class RandCreator
        {
            public static double Polar(Random rnd)
            {
                double randn1;
                double randn2;
                double w;
                double c;
                double z1;
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
                return z1;
            }
            
            //create random number array
            public static double[,] Rand(int N, int steps)
            {
                Random rnd = new Random();
                double[,] R = new double[N, steps];
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < steps; j++)
                    {
                        R[i, j] = RandCreator.Polar(rnd);
                    }
                }

                return R;
            }
        }
    }

    //Monte Carlo simulation
    class MonteCarlo
    {
        public static double[,] MCsimu(double S0, double sigma, double r, double T, int steps, int N, double[,] R)
        {
            double dt = T / steps;
            double[,] tree = new double[N, steps + 1];
            for (int i = 0; i < N; i++)
            {
                tree[i, 0] = S0;
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < steps; j++)
                {
                    tree[i, j + 1] = tree[i, j] * Math.Exp((r - sigma * sigma / 2) * dt + sigma * Math.Sqrt(dt) * R[i, j]);
                }
            }

            return tree;
        }
    }

    //Calculate price and std
    public class Option
    {
        public static double[] PandStd(double S0, double K, double sigma, double r, double T, int steps, int N, bool type, double[,] R)
        {
            //calcualate price
            double[] optionvalue = new double[N];
            if (type == true)
            {
                for (int i = 0; i < N; i++)
                {
                    optionvalue[i] = Math.Max(MonteCarlo.MCsimu(S0, sigma, r, T, steps, N, R)[i, steps] - K, 0);
                }
            }
            else
            {
                for (int i = 0; i < N; i++)
                {
                    optionvalue[i] = Math.Max(-MonteCarlo.MCsimu(S0, sigma, r, T, steps, N, R)[i, steps] + K, 0);
                }
            }
            double price = optionvalue.Average() * Math.Exp(-r * T);
            //calculate std
            double[] sd = new double[N];
            for (int i = 0; i < N; i++)
            {
                sd[i] = optionvalue[i] * Math.Exp(-r * T);
            }
            double sum = 0;
            for (int i = 0; i < N; i++)
            {
                sum += Math.Pow((sd[i] - price), 2);
            }
            double std = Math.Sqrt(sum / (N - 1) / N);
            //output value
            double[] value = new double[2];
            value[0] = price;
            value[1] = std;
            return value;
        }
    }

    //Calculate the Greeks
    public class Greeks
    {
        public static double Delta(double S0, double K, double sigma, double r, double T, int steps, int N, bool type, double[,] R)
        {
            double delta = (Option.PandStd(1.01 * S0, K, sigma, r, T, steps, N, type, R)[0] - Option.PandStd(0.99 * S0, K, sigma, r, T, steps, N, type, R)[0]) / (0.02 * S0);
            return delta;
        }

        public static double Gamma(double S0, double K, double sigma, double r, double T, int steps, int N, bool type, double[,] R)
        {
            double gamma = (Option.PandStd(1.01 * S0, K, sigma, r, T, steps, N, type, R)[0] + Option.PandStd(0.99 * S0, K, sigma, r, T, steps, N, type, R)[0] - 2 * Option.PandStd(S0, K, sigma, r, T, steps, N, type, R)[0]) / (Math.Pow((0.01 * S0), 2));
            return gamma;
        }

        public static double Vega(double S0, double K, double sigma, double r, double T, int steps, int N, bool type, double[,] R)
        {
            double vega = (Option.PandStd(S0, K, sigma + 0.01, r, T, steps, N, type, R)[0] - Option.PandStd(S0, K, sigma - 0.01, r, T, steps, N, type, R)[0]) / 0.02;
            return vega;
        }

        public static double Theta(double S0, double K, double sigma, double r, double T, int steps, int N, bool type, double[,] R)
        {
            double theta = (Option.PandStd(S0, K, sigma, r, 0.9 * T, steps, N, type, R)[0] - Option.PandStd(S0, K, sigma, r, T, steps, N, type, R)[0]) / (0.1 * T);
            return theta;
        }

        public static double Rho(double S0, double K, double sigma, double r, double T, int steps, int N, bool type, double[,] R)
        {
            double rho = (Option.PandStd(S0, K, sigma, r + 0.01, T, steps, N, type, R)[0] - Option.PandStd(S0, K, sigma, r - 0.01, T, steps, N, type, R)[0]) / 0.02;
            return rho;
        }
    }


}
