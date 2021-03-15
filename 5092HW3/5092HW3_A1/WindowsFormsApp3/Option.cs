using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.DataVisualization.Charting;

namespace WindowsFormsApp3
{
    //Create random number arrary 
    public class RandomNumber
    {
        //Basic method
        public double Polar(Random rnd)
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

        //Create array
        public double[,] Rand(int Trials, int N)
        {
            Random rnd = new Random();
            double[,] Rn = new double[Trials, N];
            for (int i = 0; i < Trials; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Rn[i, j] = Polar(rnd);
                }
            }
            return Rn;
        }
    }

    //Basic value used in Monte Carlo Simulation
    public class Value
    {
        public double S { get; set; }
        public double K { get; set; }
        public double R { get; set; }
        public double Sigma { get; set; }
        public double T { get; set; }
        public int Trials { get; set; }
        public int N { get; set; }
        public bool Type { get; set; }
        public double[,] Rn { get; set; }
        public bool An { get; set; }
        public bool CV { get; set; }
    }
    public class Price
    {
        Value value1 = new Value();
        public static double cdf(double x)
        {
            double a1 = 0.254829592;
            double a2 = -0.284496736;
            double a3 = 1.421413741;
            double a4 = -1.453152027;
            double a5 = 1.061405429;
            double p = 0.3275911;
            double sign = 1;
            if (x < 0)
                sign = -1;
            x = Math.Abs(x) / Math.Sqrt(2.0);
            double t = 1.0 / (1.0 + p * x);
            double y = 1.0 - (((((a5 * t + a4) * t) + a3) * t + a2) * t + a1) * t * Math.Exp(-x * x);
            return 0.5 * (1.0 + sign * y);
        }
        public double BSdelta(double S, double K, double R, double Sigma, double T, bool Type)
        {

            double d1 = (Math.Log(S / K) + (R + 0.5 * Sigma * Sigma) * T) / (Sigma * Math.Sqrt(T));
            if (Type == true)
                return cdf(d1);
            else
                return cdf(d1) - 1;
        }

        public double[] Oprice(Value value1)
        {
            //Use antithetic variance reduction or not
            double[] result = new double[2];

            if (value1.An == true)
            {
                //build an array to load all stock price
                double[,] tree1 = new double[value1.Trials, value1.N + 1];
                double[,] tree2 = new double[value1.Trials, value1.N + 1];

                //build an array to load all option price
                double[] optionvalue1 = new double[value1.Trials];
                double[] optionvalue2 = new double[value1.Trials];
                double sum1 = 0;
                double sum2 = 0;
                double ct = 0;
                int beta1 = -1;


                if (value1.CV == true)
                {
                    for (int i = 0; i < value1.Trials; i++)
                    {
                        tree1[i, 0] = value1.S;
                        tree2[i, 0] = value1.S;
                        double cv1 = 0;
                        double cv2 = 0;

                        for (int j = 0; j < value1.N; j++)
                        {
                            double delta1 = BSdelta(tree1[i, j], value1.K, value1.R, value1.Sigma, value1.T - j * value1.T / value1.N, value1.Type);
                            double delta2 = BSdelta(tree2[i, j], value1.K, value1.R, value1.Sigma, value1.T - j * value1.T / value1.N, value1.Type);

                            tree1[i, j + 1] = tree1[i, j] * Math.Exp((value1.R - value1.Sigma * value1.Sigma / 2) * value1.T / value1.N + value1.Sigma * Math.Sqrt(value1.T / value1.N) * value1.Rn[i, j]);
                            tree2[i, j + 1] = tree2[i, j] * Math.Exp((value1.R - value1.Sigma * value1.Sigma / 2) * value1.T / value1.N - value1.Sigma * Math.Sqrt(value1.T / value1.N) * value1.Rn[i, j]);

                            cv1 += delta1 * (tree1[i, j + 1] - tree1[i, j] * Math.Exp(value1.R * value1.T / value1.N));
                            cv2 += delta2 * (tree2[i, j + 1] - tree2[i, j] * Math.Exp(value1.R * value1.T / value1.N));
                        }

                        if (value1.Type == true)
                        {
                            optionvalue1[i] = Math.Max(tree1[i, value1.N] - value1.K, 0) + beta1 * cv1;
                            optionvalue2[i] = Math.Max(tree2[i, value1.N] - value1.K, 0) + beta1 * cv2;
                            ct = 0.5 * (optionvalue1[i] + optionvalue2[i]);
                            sum1 += ct;
                            sum2 += ct * ct;
                        }
                        else
                        {
                            optionvalue1[i] = Math.Max(-tree1[i, value1.N] + value1.K, 0) + beta1 * cv1;
                            optionvalue2[i] = Math.Max(-tree2[i, value1.N] + value1.K, 0) + beta1 * cv2;
                            ct = 0.5 * (optionvalue1[i] + optionvalue2[i]);
                            sum1 += ct;
                            sum2 += ct * ct;
                        }
                    }
                }

                else
                {
                    for (int i = 0; i < value1.Trials; i++)
                    {
                        tree1[i, 0] = value1.S;
                        tree2[i, 0] = value1.S;

                        for (int j = 0; j < value1.N; j++)
                        {

                            tree1[i, j + 1] = tree1[i, j] * Math.Exp((value1.R - value1.Sigma * value1.Sigma / 2) * value1.T / value1.N + value1.Sigma * Math.Sqrt(value1.T / value1.N) * value1.Rn[i, j]);
                            tree2[i, j + 1] = tree2[i, j] * Math.Exp((value1.R - value1.Sigma * value1.Sigma / 2) * value1.T / value1.N - value1.Sigma * Math.Sqrt(value1.T / value1.N) * value1.Rn[i, j]);
                        }

                        if (value1.Type == true)
                        {
                            optionvalue1[i] = Math.Max(tree1[i, value1.N] - value1.K, 0);
                            optionvalue2[i] = Math.Max(tree2[i, value1.N] - value1.K, 0);
                            ct = 0.5 * (optionvalue1[i] + optionvalue2[i]);
                            sum1 += ct;
                            sum2 += ct * ct;
                        }
                        else
                        {
                            optionvalue1[i] = Math.Max(-tree1[i, value1.N] + value1.K, 0);
                            optionvalue2[i] = Math.Max(-tree2[i, value1.N] + value1.K, 0);
                            ct = 0.5 * (optionvalue1[i] + optionvalue2[i]);
                            sum1 += ct;
                            sum2 += ct * ct;
                        }
                    }
                }
                //get option price
                double optionprice = sum1 / value1.Trials * Math.Exp(-value1.R * value1.T);

                //focus on std
                double sd = Math.Sqrt((sum2 - sum1 * sum1 / value1.Trials) * Math.Exp(-2 * value1.R * value1.T) / (value1.Trials - 1));
                double se = sd / Math.Sqrt(value1.Trials);

                result[0] = optionprice;
                result[1] = se;
            }

            //normal method
            else
            {
                //build an array to load all stock price
                double[,] tree = new double[value1.Trials, value1.N + 1];

                //build an array to load all option price
                double[] optionvalue = new double[value1.Trials];
                double sum1 = 0;
                double sum2 = 0;
                double ct;
                int beta1 = -1;


                if (value1.CV == true)
                {
                    for (int i = 0; i < value1.Trials; i++)
                    {
                        tree[i, 0] = value1.S;
                        double cv = 0;

                        for (int j = 0; j < value1.N; j++)
                        {
                            double delta1 = BSdelta(tree[i, j], value1.K, value1.R, value1.Sigma, value1.T - j * value1.T / value1.N, value1.Type);
                            tree[i, j + 1] = tree[i, j] * Math.Exp((value1.R - value1.Sigma * value1.Sigma / 2) * value1.T / value1.N + value1.Sigma * Math.Sqrt(value1.T / value1.N) * value1.Rn[i, j]);
                            cv += delta1 * (tree[i, j + 1] - tree[i, j] * Math.Exp(value1.R * value1.T / value1.N));
                        }

                        if (value1.Type == true)
                        {
                            optionvalue[i] = Math.Max(tree[i, value1.N] - value1.K, 0) + beta1 * cv;
                            ct = optionvalue[i];
                            sum1 += ct;
                            sum2 += ct * ct;
                        }
                        else
                        {
                            optionvalue[i] = Math.Max(-tree[i, value1.N] + value1.K, 0) + beta1 * cv;
                            ct = optionvalue[i];
                            sum1 += ct;
                            sum2 += ct * ct;
                        }

                    }
                }
                else
                {
                    for (int i = 0; i < value1.Trials; i++)
                    {
                        tree[i, 0] = value1.S;

                        for (int j = 0; j < value1.N; j++)
                        {
                            tree[i, j + 1] = tree[i, j] * Math.Exp((value1.R - value1.Sigma * value1.Sigma / 2) * value1.T / value1.N + value1.Sigma * Math.Sqrt(value1.T / value1.N) * value1.Rn[i, j]);
                        }

                        if (value1.Type == true)
                        {
                            optionvalue[i] = Math.Max(tree[i, value1.N] - value1.K, 0);
                            ct = optionvalue[i];
                            sum1 += ct;
                            sum2 += ct * ct;
                        }
                        else
                        {
                            optionvalue[i] = Math.Max(-tree[i, value1.N] + value1.K, 0);
                            ct = optionvalue[i];
                            sum1 += ct;
                            sum2 += ct * ct;
                        }

                    }
                }
                //get option price
                double optionprice = sum1 / value1.Trials * Math.Exp(-value1.R * value1.T);

                //focus on std
                double sd = Math.Sqrt((sum2 - sum1 * sum1 / value1.Trials) * Math.Exp(-2 * value1.R * value1.T) / (value1.Trials - 1));
                double se = sd / Math.Sqrt(value1.Trials);

                result[0] = optionprice;
                result[1] = se;

            }
            return result;
        }

    }

    public class Greeks
    {
        Value value2 = new Value();
        Price price2 = new Price();
        public double Delta(Value value2)
        {
            double d = 0.001 * value2.S;

            Value a = new Value();
            a.S = value2.S + d;
            a.K = value2.K;
            a.R = value2.R;
            a.Sigma = value2.Sigma;
            a.T = value2.T;
            a.Trials = value2.Trials;
            a.N = value2.N;
            a.Type = value2.Type;
            a.Rn = value2.Rn;
            a.An = value2.An;
            a.CV = value2.CV;
            double delta1 = price2.Oprice(a)[0];

            Value b = new Value();
            b.S = value2.S - d;
            b.K = value2.K;
            b.R = value2.R;
            b.Sigma = value2.Sigma;
            b.T = value2.T;
            b.Trials = value2.Trials;
            b.N = value2.N;
            b.Type = value2.Type;
            b.Rn = value2.Rn;
            b.An = value2.An;
            b.CV = value2.CV;
            double delta2 = price2.Oprice(b)[0];

            double delta = (delta1 - delta2) / (2 * d);
            return delta;
        }

        public double Gamma(Value value2)
        {
            double d = 0.001 * value2.S;

            Value a = new Value();
            a.S = value2.S + d;
            a.K = value2.K;
            a.R = value2.R;
            a.Sigma = value2.Sigma;
            a.T = value2.T;
            a.Trials = value2.Trials;
            a.N = value2.N;
            a.Type = value2.Type;
            a.Rn = value2.Rn;
            a.An = value2.An;
            a.CV = value2.CV;
            double gamma1 = price2.Oprice(a)[0];

            Value b = new Value();
            b.S = value2.S - d;
            b.K = value2.K;
            b.R = value2.R;
            b.Sigma = value2.Sigma;
            b.T = value2.T;
            b.Trials = value2.Trials;
            b.N = value2.N;
            b.Type = value2.Type;
            b.Rn = value2.Rn;
            b.An = value2.An; a.CV = value2.CV;
            b.CV = value2.CV;
            double gamma2 = price2.Oprice(b)[0];

            double gamma3 = price2.Oprice(value2)[0];
            double gamma = (gamma1 + gamma2 - 2 * gamma3) / (d * d);
            return gamma;
        }
        public double Vega(Value value2)
        {
            double d = 0.001 * value2.Sigma;

            Value a = new Value();
            a.S = value2.S;
            a.K = value2.K;
            a.R = value2.R;
            a.Sigma = value2.Sigma + d;
            a.T = value2.T;
            a.Trials = value2.Trials;
            a.N = value2.N;
            a.Type = value2.Type;
            a.Rn = value2.Rn;
            a.An = value2.An;
            a.CV = value2.CV;
            double vega1 = price2.Oprice(a)[0];

            Value b = new Value();
            b.S = value2.S;
            b.K = value2.K;
            b.R = value2.R;
            b.Sigma = value2.Sigma - d;
            b.T = value2.T;
            b.Trials = value2.Trials;
            b.N = value2.N;
            b.Type = value2.Type;
            b.Rn = value2.Rn;
            b.An = value2.An;
            b.CV = value2.CV;
            double vega2 = price2.Oprice(b)[0];

            double vega = (vega1 - vega2) / (2 * d);
            return vega;
        }
        public double Theta(Value value2)
        {
            double d = value2.T / value2.Trials;

            Value a = new Value();
            a.S = value2.S;
            a.K = value2.K;
            a.R = value2.R;
            a.Sigma = value2.Sigma;
            a.T = value2.T - d;
            a.Trials = value2.Trials;
            a.N = value2.N;
            a.Type = value2.Type;
            a.Rn = value2.Rn;
            a.An = value2.An;
            a.CV = value2.CV;
            double theta1 = price2.Oprice(a)[0];

            double theta2 = price2.Oprice(value2)[0];

            double theta = (theta1 - theta2) / d;
            return theta;
        }


        public double Rho(Value value2)
        {
            double d = 0.001 * value2.R;

            Value a = new Value();
            a.S = value2.S;
            a.K = value2.K;
            a.R = value2.R + d;
            a.Sigma = value2.Sigma;
            a.T = value2.T;
            a.Trials = value2.Trials;
            a.N = value2.N;
            a.Type = value2.Type;
            a.Rn = value2.Rn;
            a.An = value2.An;
            a.CV = value2.CV;
            double rho1 = price2.Oprice(a)[0];

            Value b = new Value();
            b.S = value2.S;
            b.K = value2.K;
            b.R = value2.R - d;
            b.Sigma = value2.Sigma;
            b.T = value2.T;
            b.Trials = value2.Trials;
            b.N = value2.N;
            b.Type = value2.Type;
            b.Rn = value2.Rn;
            b.An = value2.An;
            b.CV = value2.CV;
            double rho2 = price2.Oprice(b)[0];

            double rho = (rho1 - rho2) / (2 * d);
            return rho;
        }


    }

}
