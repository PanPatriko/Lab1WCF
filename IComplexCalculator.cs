using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Lab1Wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IComplexCalculator
    {

        [OperationContract (Name = "AddComplexData")]
        Complex Add(Complex a, Complex b);

        [OperationContract (Name = "AddDoubleData")]
        Complex Add(double ar,double ai, double br, double bi);

        [OperationContract (Name = "SubstractComplexData")]
        Complex Substract(Complex a, Complex b);

        [OperationContract (Name = "SubstractDoubleData")]
        Complex Substract(double ar, double ai, double br, double bi);

        [OperationContract (Name = "DivideComplexData")]
        Complex Divide(Complex a, Complex b);

        [OperationContract (Name = "DivideDoubleData")]
        Complex Divide(double ar, double ai, double br, double bi);

        [OperationContract (Name = "MultiplyComplexData")]
        Complex Multiply(Complex a, Complex b);

        [OperationContract (Name = "MultiplyDoubleData")]
        Complex Multiply(double ar, double ai, double br, double bi);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Complex
    {
        double real;
        double imag;

        [DataMember]
        public double Real
        {
            get { return real; }
            set { real = value; }
        }

        [DataMember]
        public double Imag
        {
            get { return imag; }
            set { imag = value; }
        }
    }
}

