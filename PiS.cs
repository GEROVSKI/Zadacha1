using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1
{
    internal class PiS
    {
        public static double Perimetur(double a, double b, double c)
        {
            if (a+b>c&&a+c>b&&b+c>a)
            {
                return (a+b+c);
            }
            else
            {
                throw new ArgumentException("tova ne sa strani na triugulnik");
            }
        }


        public static double Lice(double a, double b, double c)
        {
            double s = (a+b+c)/2;

            return Math.Sqrt(s*(s-a)*(s-b)*(s-c));
        }
    }
}
