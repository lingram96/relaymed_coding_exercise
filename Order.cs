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

    }
}