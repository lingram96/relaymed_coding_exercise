using System;
using System.Collections;
using System.Collections.Generic;
using RelayMed;


namespace RelayMed
{

    class PatientTest
    {
        public string patient { get; set; }
        public int orderNumber { get; set; }
        public string orderType { get; set; }
        public string testResult { get; set; }


        public PatientTest (string _patient, int _orderNumber, string _orderType, string _testResult)
            {
            patient = _patient;
            orderNumber = _orderNumber;
            orderType = _orderType;
            testResult = _testResult;
         }
        public string Patient
        {
            get { return patient; }
        }

        public int PatientOrderNumber
        {
            get { return orderNumber;}
        }

        public string PatientOrderType
        {
            get { return orderType;}
        }


        public string PatientTestResult
        {
            get { return testResult;}
        }


       

    }
}