using System;
using RelayMed;


namespace RelayMed
{

    class Patient
    {
        public string name { get; set; }
        public int orders { get; set; }
        private double medicalRecordNumber { get; set; }

        public Patient (string _name, double _mrn)
        {
            name = _name;
            orders = 0;
            medicalRecordNumber = _mrn;
        }

        public string PatientName
        {
            get { return name; }
        }

        public int PatientOrders
        {
            get { return orders;}
        }

        public double PatientMRN
        {
            get { return medicalRecordNumber;}
        }

        public static void CreatePatient()
        {

            Console.WriteLine("Please enter patient name: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Patient name is {name}.");
        }

        public static void UpdatePatient()
        {
            
        }

    }
}