﻿using System;
using System.Globalization;

namespace Estudo
{
    class Program
    {
        static void Main(string[] args) {

           double media, A,B;

            A= double.Parse (Console.ReadLine(),CultureInfo.InvariantCulture);
            B= double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);

            media = ((A * 3.5) + (B * 7.5)) / 11;

            Console.WriteLine ("MEDIA = "+media.ToString("F5", CultureInfo.InvariantCulture));


        
        }
    }

}
