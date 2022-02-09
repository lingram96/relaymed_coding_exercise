using System;
using RelayMed;

namespace RelayMed
{

    class Order
    {
        public int orderNum { get; set; }
        public string orderType  { get; set; }

        public Order (int _orderNum, string _orderType)
        {
            orderNum = _orderNum;
            orderType = _orderType;
        }

        public int OrderNumber
        {
            get { return orderNum; }
        }

        public string OrderType
        {
            get { return orderType;}
        }

        public static void AddOrder()
        {
            Console.WriteLine("Enter patient MRN: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Add order type: ");
            string type = Console.ReadLine();

          /* create a for loop to check the entered MRN matches to a patient already created, if it does then add order to that patient.
          If it does not equal MRN then throw error message and prompt user to try again, or to add a patient first.
          */

            Console.WriteLine($"You have added {type} to patient {number}");
        }

        public static void RemoveOrder()
        {
            Console.WriteLine("Enter order number to remove from database: ");

            /* create an if statement to check the entered MRN matches to a patient already created, if it does then remove order.
            If it does not equal MRN then throw error message and prompt user to try again.
            */
        }

    }
}