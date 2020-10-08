using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Lab1Wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ComplexCalculator : IComplexCalculator
    {
        public Complex Add(Complex a, Complex b)
        {
            return CalcAdd(a.Real, a.Imag, b.Real, b.Imag);
        }

        public Complex Add(double ar, double ai, double br, double bi)
        {
            return CalcAdd(ar, ai, br, bi);
        }

        private Complex CalcAdd(double ar, double ai, double br, double bi)
        {
            Complex complex = new Complex();
            complex.Real = ar + br;
            complex.Imag = ai + bi;
            return complex;
        }
        public Complex Divide(Complex a, Complex b)
        {
            return CalcDivide(a.Real, a.Imag, b.Real, b.Imag);
        }

        public Complex Divide(double ar, double ai, double br, double bi)
        {
            return CalcDivide(ar, ai, br, bi);
        }

        private Complex CalcDivide(double ar, double ai, double br, double bi)
        {
            Complex complex = new Complex();
            complex.Real = ((ar * br) + (ai * bi)) / ((Math.Pow(br, 2) + Math.Pow(bi, 2)));
            complex.Imag = (-(ar * bi) + (ai * br)) / ((Math.Pow(br, 2) + Math.Pow(bi, 2)));
            return complex;
        }
        public Complex Multiply(Complex a, Complex b)
        {
            return CalcMultiply(a.Real, a.Imag, b.Real, b.Imag);
        }

        public Complex Multiply(double ar, double ai, double br, double bi)
        {
            return CalcMultiply(ar, ai, br, bi);
        }

        private Complex CalcMultiply(double ar, double ai, double br, double bi)
        {
            Complex complex = new Complex();
            complex.Real = ((ar * br) - (ai * bi));
            complex.Imag = (ar * bi) + (ai * br);
            return complex;
        }
        public Complex Substract(Complex a, Complex b)
        {
            return CalcSubstract(a.Real, a.Imag, b.Real, b.Imag);
        }

        public Complex Substract(double ar, double ai, double br, double bi)
        {
            return CalcSubstract(ar, ai, br, bi);
        }
        private Complex CalcSubstract(double ar, double ai, double br, double bi)
        {
            Complex complex = new Complex();
            complex.Real = ar - br;
            complex.Imag = ai - bi;
            return complex;
        }
    }
}
