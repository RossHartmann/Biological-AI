using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticFaraday.Utility
{
    public static class MathFunctions
    {
        public static double Erf(double x)
        {
            double result = 0;
            double xsq = 0;
            double s = 0;
            double p = 0;
            double q = 0;

            s = Math.Sign(x);
            x = Math.Abs(x);
            if ((double)(x) < (double)(0.5))
            {
                xsq = x * x;
                p = 0.007547728033418631287834;
                p = 0.288805137207594084924010 + xsq * p;
                p = 14.3383842191748205576712 + xsq * p;
                p = 38.0140318123903008244444 + xsq * p;
                p = 3017.82788536507577809226 + xsq * p;
                p = 7404.07142710151470082064 + xsq * p;
                p = 80437.3630960840172832162 + xsq * p;
                q = 0.0;
                q = 1.00000000000000000000000 + xsq * q;
                q = 38.0190713951939403753468 + xsq * q;
                q = 658.070155459240506326937 + xsq * q;
                q = 6379.60017324428279487120 + xsq * q;
                q = 34216.5257924628539769006 + xsq * q;
                q = 80437.3630960840172826266 + xsq * q;
                result = s * 1.1283791670955125738961589031 * x * p / q;
                return result;
            }
            if ((double)(x) >= (double)(10))
            {
                result = s;
                return result;
            }
            result = s * (1 - Erfc(x));
            return result;
        }


        public static double Erfc(double x)
        {
            double result = 0;
            double p = 0;
            double q = 0;

            if ((double)(x) < (double)(0))
            {
                result = 2 - Erfc(-x);
                return result;
            }
            if ((double)(x) < (double)(0.5))
            {
                result = 1.0 - Erf(x);
                return result;
            }
            if ((double)(x) >= (double)(10))
            {
                result = 0;
                return result;
            }
            p = 0.0;
            p = 0.5641877825507397413087057563 + x * p;
            p = 9.675807882987265400604202961 + x * p;
            p = 77.08161730368428609781633646 + x * p;
            p = 368.5196154710010637133875746 + x * p;
            p = 1143.262070703886173606073338 + x * p;
            p = 2320.439590251635247384768711 + x * p;
            p = 2898.0293292167655611275846 + x * p;
            p = 1826.3348842295112592168999 + x * p;
            q = 1.0;
            q = 17.14980943627607849376131193 + x * q;
            q = 137.1255960500622202878443578 + x * q;
            q = 661.7361207107653469211984771 + x * q;
            q = 2094.384367789539593790281779 + x * q;
            q = 4429.612803883682726711528526 + x * q;
            q = 6089.5424232724435504633068 + x * q;
            q = 4958.82756472114071495438422 + x * q;
            q = 1826.3348842295112595576438 + x * q;
            result = Math.Exp(-Math.Pow(x, 2)) * p / q;
            return result;
        }

    }
}
