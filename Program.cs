using System;
using RelayMed;

namespace RelayMed
{

    class Program
    {
        static void Main(string[] args)
        {
            CreatePatient();
            GenerateMRN();
            Console.ReadKey();
        }

        static void CreatePatient()
        {
            Console.WriteLine("Please enter patient name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Patient name is {name}.");
        }

        static void UpdatePatient()
        {
            Console.WriteLine("Search for patient by name: ");
        }

        static void GenerateMRN()
        {
            Random numberGen = new Random();
            string mrn = "MRN-ID" + numberGen.Next(10, 9999);
            Console.WriteLine($"Patient Medical Record Number is {mrn}");
        }

        static void RemoveOrder()
        {

        }
    }
}