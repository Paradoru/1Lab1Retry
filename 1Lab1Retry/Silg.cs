using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Lab1Retry
{
    internal class Silg
    {
        public double R { get; set; } // Скорость м/сек
        public double T { get; set; } //Время в минутах
        public double S { get; set; } //Сила F
        public Silg(double r, double t, double s)
        {
            R = r;
            T = t;
            S = s;
        }
        public double Rashet()
        {
            return S * R * 60 * T;
        }
    }

}