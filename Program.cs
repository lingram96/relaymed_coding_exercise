using System;
using System.Collections.Generic;
using RelayMed;

namespace RelayMed
{

    class Program
    {
        static void Main(string[] args)
        {
            List<string> patientsList = new List<string>{};

            Patient.CreatePatient();
            Patient.CreatePatient();
            for (int i = 0; i < patientsList.Count; i++)
            {
                Console.WriteLine(patientsList[i]);
            }
            Console.ReadKey();
            Patient.GenerateMRN();
            Console.ReadKey();
        }

    }
}