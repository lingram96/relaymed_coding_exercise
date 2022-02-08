using System;
using RelayMed;


namespace RelayMed
{

    class Patient
    {
        public string name { get; set; }
        public int orders { get; set; }
        public double medicalRecordNumber { get; set; }

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

    }
}