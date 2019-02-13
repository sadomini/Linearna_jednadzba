using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linearna_jednadzba
{
    class Pravac
    {
        private double koeficijent_a;
        private double koeficijent_b;
        public static bool točkaT = false;
        public static double tX;
       

        public Pravac() { }

        private Pravac(double a, double b)
        {
            koeficijent_a = a;
            koeficijent_b = b;
        }

        public double KoefA
        {
            get { return koeficijent_a; }
            set { koeficijent_a = value; }
        }
        public double KoefB
        {
            get { return koeficijent_b; }
            set { koeficijent_b = value; }
        }

        public double JednadzbaPravca(double x)
        {
            return koeficijent_a * x + koeficijent_b;

        }

      

        public static void TočkaSjecišta(Pravac linearni1, Pravac linearni2)
        {
            if (linearni1.koeficijent_a == linearni2.koeficijent_a)
            {
                točkaT = false;
            }

            else
            {
                tX = (linearni2.koeficijent_b - linearni1.koeficijent_b) / (linearni1.koeficijent_a - linearni2.koeficijent_a);
             
                točkaT = true;
            }

        }

        public override string ToString()
        {
            if (točkaT)
                return String.Format("T ( {0:F2} , {1:F2} )", tX, JednadzbaPravca(tX));
            else
                return string.Format("-------");
        }
    }

}
