using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


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
        public double[,] Rand(int Trials, int N, bool MT)
        {
            int core_num;
            if (MT == true)
            {
                core_num = System.Environment.ProcessorCount;
            }
            else
            {
                core_num = 1;
            }
            int task_num;
            if (Trials % core_num == 0)
            {
                task_num = Trials / core_num;
            }
            else
            {
                task_num = Trials / core_num + 1;
            }
            double[,] Rn = new double[task_num * core_num, N];

            Action<object> Mthread = (mthread) =>
            {
                int tasks = Convert.ToInt32(mthread) + task_num;
                Random rnd = new Random();
                for (int i = Convert.ToInt32(mthread); i < tasks; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        Rn[i, j] = Polar(rnd);
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
            return Rn;
        }

    }
}
