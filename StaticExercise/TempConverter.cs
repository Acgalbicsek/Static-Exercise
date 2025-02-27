using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    internal static class TempConverter 
    {

        public static double FToC(double C)
        {
            return (C - 32) * 5 / 9;


        }
        

        public static double CToF(double F)
        {

           
            var result = (F * 9 / 5) + 32;
            return result;



        }







    }
}
