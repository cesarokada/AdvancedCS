using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAvancado
{
    public delegate int SomaDel(int a, int b);
    public delegate int DivideDel(int a, int b);
    public delegate int MultiplyDel(int a, int b);
    public delegate int PowDel(int a, int b);
    public delegate int SubDel(int a, int b);
    public delegate int SqrtDel(int a);


    public class Calculadora
    {
        public SomaDel Soma { get; set; }
        public DivideDel Divide { get; set; }
        public MultiplyDel Multiply { get; set; }
        public PowDel Pow { get; set; }
        public SubDel Subtraction { get; set; }
        public SqrtDel Sqrt { get; set; }
    }

    public class CalculadoraImp
    {
        public int Soma(int a, int b)
        {
            try
            {
                return a + b;
            }
            catch(Exception e)
            {
                throw e;
            }
            
        }

        public int Divide(int a, int b)
        {
            try
            {
                return a / b;

            }
            catch(DivideByZeroException e)
            {
                throw e;
            }
        }

        public int Multiply(int a, int b)
        {
            try
            {
                return a * b;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public int Pow(int a, int b)
        {
            try
            {
                return (int)Math.Pow(a, b);

            }
            catch (DivideByZeroException e)
            {
                throw e;
            }            
        }

        public int Subtraction(int a, int b)
        {
            try
            {
                return a - b;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public int Sqrt(int a)
        {
            if (a < 0)
            {
                throw new ArgumentOutOfRangeException("a (Parametro nao deve ser negativo)");
            } 
            return (int)Math.Sqrt(a);                        
        }

    }
}
