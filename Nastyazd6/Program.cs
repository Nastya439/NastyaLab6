using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nastyazd6
{
    //    class Program
    //    {
    //        static void Main(string[] args)
    //        {
    //            void F(int nn, out double X)
    //            {
    //                X = 1;
    //                for (int i = 1; i <= nn; i++)
    //                    X = X * i;
    //            }
    //            Console.Write("c=");
    //            int c = Convert.ToInt16(Console.ReadLine());
    //            Console.Write("x=");
    //            int x = Convert.ToInt16(Console.ReadLine());
    //            Console.Write("k=");
    //            int k = Convert.ToInt16(Console.ReadLine());

    //            F(c, out double p1);
    //            F(c, out double p2);
    //            F(c, out double p3);
    //            double f = (c - x) ^ k / c ^ k * (c) - (k);
    //            Console.WriteLine($"y={f,8:f3}");
    //        }
    //    }
    //}


    class Program
    {
        static void Main(string[] args)
        {
            double F(int nn)
            {
                double X = 1;
                for (int i = 1; i <= nn; i++)
                    X = X * i;
                return X;

            }
            Console.Write("c=");
            int c = Convert.ToInt16(Console.ReadLine());
            Console.Write("x=");
            int x = Convert.ToInt16(Console.ReadLine());
            Console.Write("k=");
            int k = Convert.ToInt16(Console.ReadLine());
            double f = (c - x) ^ k / c ^ k * (c) - (k);
            Console.WriteLine($"y={f,8:f3}");
        }
    }