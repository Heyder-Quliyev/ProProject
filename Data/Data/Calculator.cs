using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    internal class Calculator :ISum, IMultiply, IDifference, IDivide, IRectangles, ICircle
    {
        public double Sum(params double[] numbers)
        {
            double sum = 0;
            for (int i = 0; i<numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        public double Multiply(params double[] numbers) 
        {
            double mult = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                mult *= numbers[i];
            }
            return mult;
        }
        public double Divide(params double[] numbers) 
        {
            double divide = 10000;
            for (int i = 0; i < numbers.Length; i++)
            {
                divide /= numbers[i] /*/ divide*/;
            }
            return divide;
        }
        public double Difference (params double[] numbers)
        {
            double difference = 1000;
            for (int i = 0; i < numbers.Length; i++)
            {
                difference -= numbers[i];
            }
            return difference;
        }

        public int Rectangle(int a, int b)
        {
            int rectan = 1;         
            
                rectan = a*b;
            
            return rectan;
        }
        public double Area(double radius)
        {
            return radius * radius*Math.PI;

        }
        public double Perimetr(double radius)
        { 
            return radius * radius*Math.PI;
        }


        public int Triangle(int h, int b)
        {
            int Tri = 1;
            Tri = (h*b)/2;
            return Tri;
        }

        public double Sum(int a, int b)
        {
            throw new NotImplementedException();
        }

        double ICircle.Area(double radius)
        {
            throw new NotImplementedException();
        }

        double ICircle.perimetr(double radius)
        {
            throw new NotImplementedException();
        }
    }
}
