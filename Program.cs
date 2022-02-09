using System;
using System.Collections.Generic;
using RelayMed;

namespace RelayMed
{

    class Program
    {
        static void Main(string[] args)
        {

            Patient.CreatePatient();
            Console.ReadKey();
            Patient.GenerateMRN();
            Console.ReadKey();
        }

    }
}