namespace WindowsFormsApp3
{
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
        public bool MT { get; set; }
        public double Rb { get; set; }
        public double Br { get; set; }
        public int Bt { get; set; }
    }

}
