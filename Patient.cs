using System;
using RelayMed;



namespace RelayMed
{

    class Patient
    {
        public string name;
        public int orders;
        private double medicalRecordNumber;

        public Patient (string _name, int _orders, double _mrn)
        {
            name = _name;
            orders = _orders;
            medicalRecordNumber = _mrn;

        }

        public static void CreatePatient()
        {
            Patient patient01 = new Patient("Bob", 5, 1234566);

            Console.WriteLine(patient01.name);
            Console.WriteLine(patient01.orders);
            Console.WriteLine(patient01.medicalRecordNumber);
        }
    }
}