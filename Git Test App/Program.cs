﻿using System;

namespace Git_Test_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Git Test App v0.0.00.001");

            Console.WriteLine("Feature A.02");
            Console.WriteLine("Feature B.02");
            Console.WriteLine("Feature C.01");
            FeatureD();

            Console.Read();
        }

        static void FeatureD()
        {
            Console.WriteLine("Feature D.09");
            Console.WriteLine("dev1.04");
            Console.WriteLine("dev2.02");
            Console.WriteLine("dev3.01");
        }
    }
}
