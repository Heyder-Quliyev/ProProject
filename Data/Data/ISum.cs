using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    internal interface ISum
    {
        double Sum(params double[] numbers);
    }
    internal interface IMultiply
    {
        double Sum(params double[] numbers);

    }
    internal interface IDifference
    {
        double Sum(params double[] numbers);

    }
    internal interface IDivide
    {
        double Sum(params double[] numbers);

    }

    internal interface IRectangles
    {
        double Sum(int a, int b);

    }

    internal interface ICircle
    {
        double Area(double radius);
        double perimetr(double radius);

    }
    internal interface ITriangle
    {
        double Sum(int a, int b);

    }

    internal interface ISquare
    {
        double Sum(int a, int b);

    }





}
