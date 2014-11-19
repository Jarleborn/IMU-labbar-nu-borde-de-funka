using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb_5
{
    class Fraction
    {
        private int _t;
        private int _n;

        // täljare
        public int getNumerator { get { return _t; } set { _t = value; } }

        // nämnare
        public int getDenominator
        {
            get { return _n; }
            set
            {
                if (value == 0)
                {
                    throw new Exception("Feeel");
                }
                _n = value;
            }
        }

        public Fraction(int a, int b)
        {
            getNumerator = a;
            try
            {
                getDenominator = b;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }

        //public Fraction() {
        //}

        public bool isNegative(int a, int b)
        {
            if (a < 0 || b < 0)
            {
                return true;
            }
            return false;
        }

        public Fraction add(Fraction a, Fraction b)
        {
            if (a.getDenominator == b.getDenominator)
            {

                return new Fraction(b.getNumerator + a.getNumerator, a.getDenominator);
            }
            return new Fraction(a.getNumerator * b.getDenominator + b.getNumerator * a.getDenominator, a.getDenominator * b.getDenominator);

        }

        public Fraction multiply(Fraction a, Fraction b)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
            return new Fraction(a.getNumerator * b.getNumerator,
               a.getDenominator * b.getDenominator);

        }

        public bool isEqualTo()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return String.Format("{0}:{1}", getNumerator, getDenominator);
        }
    }
}