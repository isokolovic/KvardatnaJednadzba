using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KvardatnaJednadzba
{
    class QuadraticEquation
    {
        public QuadraticEquation() //objekt će imati defaultne vrijednosti, za double = 0
        {

        }

        public QuadraticEquation(double a, double b, double c)
        {
            this.a = a; //potrebno inicijalizirati
            this.b = b;
            this.c = c;
        }

        public double A
        {
            get { return a; }
            set { a = value; }
        }

        public double B
        {
            get { return b; }
            set { b = value; }
        }
        public double C
        {
            get { return c; }
            set { c = value; } //value = po konvenciji
        }

        public double Y(double x) //Kvadratna jednadžba
        {
            return a * x * x + b * x + c;
        }

        public double Discriminant
        {
            get { return b * b - 4 * a * c; }
        }

        public double[] Roots
        {
            get
            {
                if(a == 0)
                {
                    return new double[] { -c / b, -c / b };
                }

                double sqrtDisc = Math.Sqrt(Discriminant);
                return new double[] { (-b - sqrtDisc) / 2 / a , 
                    (-b + sqrtDisc) / 2 / a };
            }
        }

        private double a;
        private double b;
        private double c;

    }
}
