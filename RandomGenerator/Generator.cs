using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGenerator
{
    public class Generator
    {
        private long XN = 19713, XNM1 = 30001, XNM2 = 19, AA0 = 17, AA1 = 31767, AA2 = 999, MU = 255, M = 3291767;
        private int min, max;
        private Stopwatch sw = new Stopwatch();
        private long GRD(int xn, int xnm1, int xnm2, int a0, int a1, int a2, int mu, int m)
        {
            long xmp1 = ((Convert.ToInt64(a0) * Convert.ToInt64(xn)) % m + (Convert.ToInt64(a1) * Convert.ToInt64(xnm1)) % m + (Convert.ToInt64(a2) * Convert.ToInt64(xnm2)) % m + mu) % m;
            XNM2 = XNM1;
            XNM1 = XN;
            XN = xmp1;
            return (xmp1);
        }
        public Generator(int min, int max)
        {
            this.min = min;
            this.max = max+1;

            sw.Start();
        }

        private double Random()
        {
            double rm;
            double U1 = 1;

            rm = 0;
            for (int j = 0; j < 12; j++)
            {
                rm = rm + (double)(GRD((int)XN, (int)XNM1, (int)XNM2, (int)AA0, (int)AA1, (int)AA2, (int)MU, (int)M)) / (double)M;
            }
            return (rm - 6) * U1;
        }

        public int GetNumber()
        {
            
            
            var time = Process.GetCurrentProcess();
            
            double t = (Random() );
            Random r = new Random((int)(t*100) + (int)sw.ElapsedTicks);
            return r.Next(min, max);
        }
    }
}
