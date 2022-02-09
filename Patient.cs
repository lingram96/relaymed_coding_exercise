using System;
using System.Collections;
using System.Collections.Generic;
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

        public static void CreatePatient()
        {
            List<string> patientsList = new List<string>{};

            Console.WriteLine("Please enter patient name: ");
            string name = Console.ReadLine();

            patientsList.Add(name);

            for (int i = 0; i < patientsList.Count; i++)
            {
                Console.WriteLine(patientsList[i]);
            }
            
            // Append new patient to list of patients, then show the patients currently in the list
        }

        public static void GenerateMRN()
        {
            Random numberGen = new Random();
            string mrn = "ID-MRN" + numberGen.Next(10, 9999);
            Console.WriteLine($"Unique Medical Record Number is {mrn}");

        /* My thinking here is to generate a random number to create the MRN, then append this to the index of the corresponding patient.
        Perhaps have a method before this which shows how many patients are in the list, create the new patient and immediately the MRN will be generated and added. 
        */
        }

         public static void UpdatePatient()
        {
            Console.WriteLine("Search for patient by name: ");

            // create a for loop here to iterate over an array or list of patients, until the patient name or MRN matches, then update with new name.
        }

    }
}