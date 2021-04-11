using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace WindowsFormsApp3
{
    class Barrier: Option
    {
        public override double payoff1(Value value1, double[,] tree1, int i)
        {
            double[] payoff = new double[value1.Trials];
            //down and out
            if (value1.Bt == 0)
            {
                if (minnumber(tree1, i) <= value1.Br)
                {
                    payoff[i] = 0;
                }
                else
                {
                    payoff[i] = 1;
                }
            }

            //up and out
            if (value1.Bt == 1)
            {
                if (maxnumber(tree1, i) >= value1.Br)
                {
                    payoff[i] = 0;
                }
                else
                {
                    payoff[i] = 1;
                }
            }

            //down and in
            if (value1.Bt == 2)
            {
                if (minnumber(tree1, i) <= value1.Br)
                {
                    payoff[i] = 1;
                }
                else
                {
                    payoff[i] = 0;
                }
            }

            //up and in
            if (value1.Bt == 3)
            {
                if (maxnumber(tree1, i) >= value1.Br)
                {
                    payoff[i] = 1;
                }
                else
                {
                    payoff[i] = 0;
                }
            }
            if (value1.Type == true)
                return payoff[i] * Math.Max(tree1[i, value1.N] - value1.K, 0);
            else
                return payoff[i] * Math.Max(-tree1[i, value1.N] + value1.K, 0);
        }

        public override double payoff2(Value value1, double[,] tree2, int i)
        {
            double[] payoff = new double[value1.Trials];
            //down and out
            if (value1.Bt == 0)
            {
                if (minnumber(tree2, i) >= value1.Br)
                {
                    payoff[i] = 0;
                }
                else
                {
                    payoff[i] = 1;
                }
            }

            //up and out
            if (value1.Bt == 1)
            {
                if (maxnumber(tree2, i) >= value1.Br)
                {
                    payoff[i] = 0;
                }
                else
                {
                    payoff[i] = 1;
                }
            }

            //down and in
            if (value1.Bt == 2)
            {
                if (minnumber(tree2, i) <= value1.Br)
                {
                    payoff[i] = 1;
                }
                else
                {
                    payoff[i] = 0;
                }
            }

            //up and in
            if (value1.Bt == 3)
            {
                if (maxnumber(tree2, i) >= value1.Br)
                {
                    payoff[i] = 1;
                }
                else
                {
                    payoff[i] = 0;
                }
            }
            if (value1.Type == true)
                return payoff[i] * Math.Max(tree2[i, value1.N] - value1.K, 0);
            else
                return payoff[i] * Math.Max(-tree2[i, value1.N] + value1.K, 0);
        }

        static double maxnumber(double[,] tree, int i)
        {
            double max = tree[i, 0];
            for (int j = 0; j < tree.GetLength(1); j++)
            {
                max = Math.Max(max, tree[i, j]);
            }
            return max;
        }

        static double minnumber(double[,] tree, int i)
        {
            double min = tree[i, 0];
            for (int j = 0; j < tree.GetLength(1); j++)
            {
                min = Math.Min(min, tree[i, j]);
            }
            return min;
        }
    }
}
