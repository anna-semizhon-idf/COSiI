using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

//y = cos2x+sin5x

namespace lab1
{
    public delegate Complex Function(Complex argValue);

    static class Fourier
    {
        static public int count;


        static public Complex[] GetFunctionValuesVector(Function func, double period, int N)
        {
            double interval = period / N;
            Complex[] funcValues = new Complex[N];

            Complex x = 0;
            for (int i = 0; i < N; i++)
            {
                funcValues[i] = func(x);
                x += interval;
            }
            return funcValues;
        }


        static public Complex[] DiscreteFourierTransform(Complex[] inputValues, int dir)
        {
            count = 0;
            if (dir != 1 && dir != -1) return new Complex[] { 0 };
            int N = inputValues.Length;
            Complex[] outputValues = new Complex[N];
            for (int k = 0; k < N; k++)
            {
                for (int m = 0; m < N; m++)
                {
                    outputValues[k] += (inputValues[m] * Complex.Exp(-dir * 2 * Math.PI * Complex.ImaginaryOne * k * m / N));
                    /////////////
                    count++;
                    ////////////
                }
                if (dir == 1)
                    outputValues[k] /= N;
            }
            return outputValues;
        }


        static public Complex[] FastFourierTransform(Complex[] inputValues, int dir)
        {
            count = 0;
            Complex[] outputValues = TimeDecimationFFT(inputValues, dir);
             FFTReOrder(outputValues, (ulong)outputValues.Length);
            return outputValues;
        }




      /*  static private Complex[] FFT(Complex[] a, int dir)
         {
             if (a.Length == 1) return a;
             int N = a.Length;

             Complex wN = Complex.Exp(- dir * 2 * Math.PI * Complex.ImaginaryOne / N);
             Complex w = new Complex(1, 0);
             Complex[] y = new Complex[N];

             Complex[] left = new Complex[N / 2];
             Complex[] right = new Complex[N / 2];

             for (int j = 0; j < N / 2; j++)
             {
                 left[j] = a[j] + a[j + N / 2];
                 right[j] = (a[j] - a[j + N / 2]) * w;
                 w = w * wN;

                 /////////////
                 count++;
                 ////////////
             }

             Complex[] b_left = FFT(left, dir);
             Complex[] b_right = FFT(right, dir);

             if(dir == 1)  // Прямое преобразование
                 for (int j = 0; j < N / 2; j++)
                 {
                     y[j] = b_left[j] / 2;
                     y[j + N / 2] = b_right[j] / 2;
                 }
             else          // Обратное преобразование
                 for (int j = 0; j < N / 2; j++)
                 {
                     y[j] = b_left[j];
                     y[j + N / 2] = b_right[j];
                 }
             return y;
         }
*/

     public static Complex[] TimeDecimationFFT(Complex[] a, int dir)
        {
            //1.
            int N = a.Length;
            if (N == 1) return a;
            //2.
            Complex[] a1 = new Complex[N / 2 + N % 2]; //Четные
            Complex[] a2 = new Complex[N / 2]; //Нечетные
            for (int i = 0; i < a.Length; i++)
            {
                if (i % 2 == 0) a1[i / 2] = a[i];
                else a2[i / 2] = a[i];
            }
            //3.
            Complex[] b1 = TimeDecimationFFT(a1, /*a1.Length,*/ dir); //четные
            Complex[] b2 = TimeDecimationFFT(a2, /*a2.Length,*/ dir); //нечетные
                                                                  //4.
            Complex wN = new Complex(Math.Cos(2 * Math.PI / N), dir * Math.Sin(2 * Math.PI / N));
            Complex w = new Complex(1, 0);
            Complex[] y = new Complex[N];

            for (int j = 0; j < N / 2; j++)
            {
                y[j] = b1[j] + b2[j] * w;
                y[j + N / 2] = b1[j] - b2[j] * w;
                w = w * wN;
            }
            //5.
            return y;
        }


        static public void FFTReOrder(Complex[] Data, ulong Len)
        {
            Complex temp;
            if (Len <= 2) return;
            ulong r = 0;
            for (ulong x = 1; x < Len; x++)
            {
                //r = rev_next(r, Len);
                if (r > x)
                {
                    temp = Data[x];
                    Data[x] = Data[r];
                    Data[r] = temp;
                }
            }
        }

        static private ulong rev_next(ulong r, ulong n)
        {
            // преобразовывает r=rev(x-1) в rev(x) 
            do
            {
                n = n >> 1; r = r ^ n;
            } while ((r & n) == 0);
            return r;
        }

    }
}