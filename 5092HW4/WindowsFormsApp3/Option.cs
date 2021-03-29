using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace WindowsFormsApp3
{
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

        public class Trees1
        {
            public double[,] Tree1(Value value1)
            {
                int core_num;
                if (value1.MT == true)
                {
                    core_num = System.Environment.ProcessorCount;
                }
                else
                {
                    core_num = 1;
                }
                int task_num;
                if (value1.Trials % core_num == 0)
                {
                    task_num = value1.Trials / core_num;
                }
                else
                {
                    task_num = value1.Trials / core_num + 1;
                }
                double[,] tree = new double[task_num * core_num, value1.N + 1];

                Action<object> Mthread = (mthread) =>
                {
                    int tasks = Convert.ToInt32(mthread) + task_num;
                    for (int i = Convert.ToInt32(mthread); i < tasks; i++)
                    {
                        tree[i, 0] = value1.S;
                        for (int j = 0; j < value1.N; j++)
                        {
                            tree[i, j + 1] = tree[i, j] * Math.Exp((value1.R - value1.Sigma * value1.Sigma / 2) * value1.T / value1.N + value1.Sigma * Math.Sqrt(value1.T / value1.N) * value1.Rn[i, j]);
                        }
                    }
                };
                int each_num = 0;
                List<Thread> thread = new List<Thread>();
                for (int i = 0; i < core_num; i++)
                {
                    Thread new_thread = new Thread(new ParameterizedThreadStart(Mthread));
                    thread.Add(new_thread);
                    new_thread.Start(each_num);
                    each_num = each_num + task_num;
                }
                foreach (Thread i in thread)
                    i.Join();
                foreach (Thread i in thread)
                    i.Abort();
                return tree;
            }
        }

        public class Trees2
        {
            public double[,] Tree2(Value value1)
            {
                int core_num;
                if (value1.MT == true)
                {
                    core_num = System.Environment.ProcessorCount;
                }
                else
                {
                    core_num = 1;
                }
                int task_num = value1.Trials / core_num;
                double[,] tree = new double[value1.Trials, value1.N + 1];

                Action<object> Mthread = (mthread) =>
                {
                    int tasks = Convert.ToInt32(mthread) + task_num;
                    for (int i = Convert.ToInt32(mthread); i < tasks; i++)
                    {
                        tree[i, 0] = value1.S;
                        for (int j = 0; j < value1.N; j++)
                        {
                            tree[i, j + 1] = tree[i, j] * Math.Exp((value1.R - value1.Sigma * value1.Sigma / 2) * value1.T / value1.N - value1.Sigma * Math.Sqrt(value1.T / value1.N) * value1.Rn[i, j]);
                        }
                    }
                };
                int each_num = 0;
                List<Thread> thread = new List<Thread>();
                for (int i = 0; i < core_num; i++)
                {
                    Thread new_thread = new Thread(new ParameterizedThreadStart(Mthread));
                    thread.Add(new_thread);
                    new_thread.Start(each_num);
                    each_num = each_num + task_num;
                }
                foreach (Thread i in thread)
                    i.Join();
                foreach (Thread i in thread)
                    i.Abort();
                return tree;
            }
        }

        public double[] Oprice(Value value1)
        {
            //Use antithetic variance reduction or not
            double[] result = new double[2];

            if (value1.An == true)
            {
                //build an array to load all stock price
                Trees1 trees1 = new Trees1();
                double[,] tree1 = trees1.Tree1(value1);
                Trees2 trees2 = new Trees2();
                double[,] tree2 = trees2.Tree2(value1);

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
                        double cv1 = 0;
                        double cv2 = 0;

                        for (int j = 0; j < value1.N; j++)
                        {
                            double delta1 = BSdelta(tree1[i, j], value1.K, value1.R, value1.Sigma, value1.T - j * value1.T / value1.N, value1.Type);
                            double delta2 = BSdelta(tree2[i, j], value1.K, value1.R, value1.Sigma, value1.T - j * value1.T / value1.N, value1.Type);

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
                Trees1 trees = new Trees1();
                double[,] tree = trees.Tree1(value1);

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
                        double cv = 0;

                        for (int j = 0; j < value1.N; j++)
                        {
                            double delta1 = BSdelta(tree[i, j], value1.K, value1.R, value1.Sigma, value1.T - j * value1.T / value1.N, value1.Type);
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

}
