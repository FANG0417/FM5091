using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace WindowsFormsApp3
{
    class Lookback: Option
    {
        public override double payoff1(Value value1, double[,] tree1, int i)
        {
            if (value1.Type == true)
                return Math.Max(maxnumber(tree1, i) - value1.K, 0);
            else
                return Math.Max(-minnumber(tree1, i) + value1.K, 0);
        }

        public override double payoff2(Value value1, double[,] tree2, int i)
        {
            if (value1.Type == true)
                return Math.Max(maxnumber(tree2, i) - value1.K, 0);
            else
                return Math.Max(-minnumber(tree2, i) + value1.K, 0);
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
