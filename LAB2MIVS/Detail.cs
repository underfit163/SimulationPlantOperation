using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Detail
    {
        private Random random = new Random();

        private double T0 {  get; set; }
        private double T1 { get; set; }
        private int N { get; set; }
        private int K { get; set; }

        public Detail(double t0 = 0, double t1 = 1, int n = 0, int k = 0)
        {
            if (t0 < 0 || t1 <= 0 || t0 >= t1)
                throw new ArgumentOutOfRangeException("Неправильно заданные интервалы");

            T0 = t0;
            T1 = t1;
            N = n;
            K = k;

        }

        public double RandN()
        {
            return random.NextDouble() * (T1 - T0) + T0;
        }

    }
}
