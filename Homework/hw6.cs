using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {   
            //simulation
            double S0 = 810;
            double K = 800;
            double T = 0.5;
            double r = 0.05;
            double sigma = 0.2;
            int N = 6;
            double del = 0.02;
            bool CorP = true;// call(c) is true and put(p) is false
            bool EorA = true;// European(u) is true and American(a) is false
            double[,] options = option.Optionprice(S0, K, T, r, sigma, N, del, CorP, EorA);
            double[] greeks = Greeks.greeks(S0, K, T, r, sigma, N, del, CorP, EorA);
            Console.WriteLine("option price:"+options[0,0]);
            Console.WriteLine("Delta :"+greeks[0]);
            Console.WriteLine("Gamma :"+greeks[1]);
            Console.WriteLine("Vega :"+greeks[2]);
            Console.WriteLine("Theta :"+greeks[3]);
            Console.WriteLine("Rho :"+greeks[4]);
            Console.ReadLine();
        }
    }

    public class Basicvalue
    {
        public static double[] basicvalue(double S0, double K, double T, double r, double sigma, int N, double del, bool CorP, bool EorA)
        {
            double dt = T / N;
            double dx = sigma * Math.Sqrt(3 * dt);
            double v = r - del - Math.Pow(sigma, 2)/2;
            double edx = Math.Pow(Math.E, dx);
            double pu = ((Math.Pow(sigma, 2) * dt + Math.Pow(v, 2) * Math.Pow(dt, 2)) / Math.Pow(dx, 2) + v * dt / dx)/2;
            double pm = 1 - (Math.Pow(sigma, 2) * dt + Math.Pow(v, 2) * Math.Pow(dt, 2)) / Math.Pow(dx, 2);
            double pd = ((Math.Pow(sigma, 2) * dt + Math.Pow(v, 2) * Math.Pow(dt, 2)) / Math.Pow(dx, 2) - v * dt / dx)/2;
            double disc = Math.Pow(Math.E, -r * dt);
            double[] result = { dt, dx, v, edx, pu, pm, pd, disc };
            return result;
         } 
    }

    public class stockprice
    {
        public static double[] Lastprice(double S0, double K, double T, double r, double sigma, int N, double del, bool CorP, bool EorA)
        {
            double[] lastprice = new double[2 * N + 1];
            double dt = Basicvalue.basicvalue(S0, K, T, r, sigma, N, del, CorP, EorA)[0];
            double dx = Basicvalue.basicvalue(S0, K, T, r, sigma, N, del, CorP, EorA)[1];
            double v = Basicvalue.basicvalue(S0, K, T, r, sigma, N, del, CorP, EorA)[2];
            double edx = Basicvalue.basicvalue(S0, K, T, r, sigma, N, del, CorP, EorA)[3];
            for (int i = 0; i <= 2 * N ; i++)
            {
                lastprice[i] = S0 * Math.Pow(edx, i-N);
            }
            return lastprice;
        }
    }

    public class option
    {
        public static double[,] Optionprice(double S0, double K, double T, double r, double sigma, int N, double del, bool CorP, bool EorA)
        {
            double[,] optiontree = new double[N+1, 2 * N + 1];
            double[] lastprice = stockprice.Lastprice(S0, K, T, r, sigma, N, del, CorP, EorA);

            double dt = Basicvalue.basicvalue(S0, K, T, r, sigma, N, del, CorP, EorA)[0];
            double dx = Basicvalue.basicvalue(S0, K, T, r, sigma, N, del, CorP, EorA)[1];
            double v = Basicvalue.basicvalue(S0, K, T, r, sigma, N, del, CorP, EorA)[2];
            double edx = Basicvalue.basicvalue(S0, K, T, r, sigma, N, del, CorP, EorA)[3];
            double pu = Basicvalue.basicvalue(S0, K, T, r, sigma, N, del, CorP, EorA)[4];
            double pm = Basicvalue.basicvalue(S0, K, T, r, sigma, N, del, CorP, EorA)[5];
            double pd = Basicvalue.basicvalue(S0, K, T, r, sigma, N, del, CorP, EorA)[6];
            double disc = Basicvalue.basicvalue(S0, K, T, r, sigma, N, del, CorP, EorA)[7];

            if(EorA)
            {
                if(CorP)
                {
                    for (int j = 0; j <= 2 * N; j++)
                    {
                        optiontree[N, j] = Math.Max(lastprice[j] - K, 0);
                    }

                    for (int i = N - 1; i >= 0; i--)
                    {
                        for (int j = 0; j <= 2 * i; j++)
                        {
                            optiontree[i, j] = disc * (pu * optiontree[i + 1, j + 2] + pm * optiontree[i + 1, j + 1] + pd * optiontree[i + 1, j]);
                        }
                    }
                }

                else
                {
                    for (int j = 0; j <= 2 * N; j++)
                    {
                        optiontree[N, j] = Math.Max(-lastprice[j] + K, 0);
                    }

                    for (int i = N - 1; i >= 0; i--)
                    {
                        for (int j = 0; j <= 2 * i; j++)
                        {
                            optiontree[i, j] = disc * (pu * optiontree[i + 1, j + 2] + pm * optiontree[i + 1, j + 1] + pd * optiontree[i + 1, j]);
                        }
                    }
                }
            }

            else
            {
                if (CorP)
                {
                    for (int j = 0; j <= 2 * N; j++)
                    {
                        optiontree[N, j] = Math.Max(lastprice[j] - K, 0);
                    }

                    for (int i = N - 1; i >= 0; i--)
                    {
                        for (int j = 0; j <= 2 * i; j++)
                        {
                            optiontree[i, j] = disc * (pu * optiontree[i + 1, j + 2] + pm * optiontree[i + 1, j + 1] + pd * optiontree[i + 1, j]);
                            optiontree[i, j] = Math.Max(optiontree[i, j], S0 * Math.Pow(edx, j - i)-K);
                        }
                    }
                }

                else
                {
                    for (int j = 0; j <= 2 * N; j++)
                    {
                        optiontree[N, j] = Math.Max(-lastprice[j]+K, 0);
                    }

                    for (int i = N - 1; i >= 0; i--)
                    {
                        for (int j = 0; j <= 2 * i; j++)
                        {
                            optiontree[i, j] = disc * (pu * optiontree[i + 1, j + 2] + pm * optiontree[i + 1, j + 1] + pd * optiontree[i + 1, j]);
                            optiontree[i, j] = Math.Max(optiontree[i, j], -S0 * Math.Pow(edx, j - i)+K);
                        }
                    }
                }

            }
           

            return optiontree;
        }
    }

    public class Greeks
    {
        public static double[] greeks(double S0, double K, double T, double r, double sigma, int N, double del, bool CorP, bool EorA)
        {
            double[,] optiontree = option.Optionprice(S0, K, T, r, sigma, N, del, CorP, EorA);

            double dt = Basicvalue.basicvalue(S0, K, T, r, sigma, N, del, CorP, EorA)[0];
            double dx = Basicvalue.basicvalue(S0, K, T, r, sigma, N, del, CorP, EorA)[1];
            double v = Basicvalue.basicvalue(S0, K, T, r, sigma, N, del, CorP, EorA)[2];
            double edx = Basicvalue.basicvalue(S0, K, T, r, sigma, N, del, CorP, EorA)[3];
            double pu = Basicvalue.basicvalue(S0, K, T, r, sigma, N, del, CorP, EorA)[4];
            double pm = Basicvalue.basicvalue(S0, K, T, r, sigma, N, del, CorP, EorA)[5];
            double pd = Basicvalue.basicvalue(S0, K, T, r, sigma, N, del, CorP, EorA)[6];
            double disc = Basicvalue.basicvalue(S0, K, T, r, sigma, N, del, CorP, EorA)[7];

            double delta = (optiontree[1, 2] - optiontree[1, 0]) / (S0 * edx - S0 / edx);
            
            double gamma = (((optiontree[1, 2] - optiontree[1, 1]) / (S0 * edx - S0)) - ((optiontree[1, 1] - optiontree[1, 0]) / (S0 - S0 / edx))) / (0.5 * S0 * (edx - 1/edx));

            double[,] optiontree1 = option.Optionprice(S0, K, T, r, sigma+0.01, N, del, CorP, EorA);
            double[,] optiontree2 = option.Optionprice(S0, K, T, r, sigma-0.01, N, del, CorP, EorA);
            double vega = (optiontree1[0, 0] - optiontree2[0, 0]) / (2 * 0.01);

            double theta = (optiontree[1, 1] - optiontree[0, 0]) /  dt;

            double[,] optiontree3 = option.Optionprice(S0, K, T, r+0.001, sigma, N, del, CorP, EorA);
            double[,] optiontree4 = option.Optionprice(S0, K, T, r-0.001, sigma, N, del, CorP, EorA);
            double rho = (optiontree3[0, 0] - optiontree4[0, 0]) / (2 * 0.001);

            double[] result2 = { delta, gamma, vega, theta, rho };
            return result2;
        }
    }



}
