namespace WindowsFormsApp3
{
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
            a.MT = value2.MT;
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
            b.MT = value2.MT;
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
            a.MT = value2.MT;
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
            b.MT = value2.MT;
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
            a.MT = value2.MT;
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
            b.MT = value2.MT;
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
            a.MT = value2.MT;
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
            a.MT = value2.MT;
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
            b.MT = value2.MT;
            double rho2 = price2.Oprice(b)[0];

            double rho = (rho1 - rho2) / (2 * d);
            return rho;
        }


    }

}
