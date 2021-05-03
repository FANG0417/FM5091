using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace WindowsFormsApp3
{
    public class Asian : Option
    {

        public override double payoff1(Value value1, double[,] tree1, int i)
        {            

            if (value1.Type == true)
                return Math.Max(averageprice(tree1, i) - value1.K, 0);
            else
                return Math.Max(-averageprice(tree1, i) + value1.K, 0);
        }

        public override double payoff2(Value value1, double[,] tree2, int i)
        {
            if (value1.Type == true)
                return Math.Max(averageprice(tree2, i) - value1.K, 0);
            else
                return Math.Max(-averageprice(tree2, i) + value1.K, 0);
        }

        static double averageprice(double[,] tree, int i)
        {
            double sumprice1 = 0;
            for (int j = 0; j < tree.GetLength(1); j++)
            {
                sumprice1 += tree[i, j];
            }
            double averageprice1 = sumprice1 / tree.GetLength(1);
            return averageprice1;
            
        }


    }

}
