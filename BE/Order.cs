using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    /// <summary>
    /// this class reporesent an order of client
    /// </summary>
    public class Order
    {
       public  int HostingUnitKey;
       public  int GuestRequestKey;
       public  int OrderKey;
       public  StatusOrder status;/// <summary>
                /// status of the order-Not addressed, sent email, closed for customer unresponsiveness, closed for customer response
                /// </summary>
       public  DateTime CreateDate;
       public  DateTime OrderDate;
        public override string ToString() { return null; } 
    }
}
