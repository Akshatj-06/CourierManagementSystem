using System;

namespace Entities
{
    public class Payment
    {
        private long paymentID;
        private long courierID;
        private double amount;
        private DateTime paymentDate;

        // Default constructor
        public Payment() { }

        // Parameterized constructor
        public Payment(long paymentID, long courierID, double amount, DateTime paymentDate)
        {
            this.paymentID = paymentID;
            this.courierID = courierID;
            this.amount = amount;
            this.paymentDate = paymentDate;
        }

        // Properties
        public long PaymentID { get => paymentID; set => paymentID = value; }
        public long CourierID { get => courierID; set => courierID = value; }
        public double Amount { get => amount; set => amount = value; }
        public DateTime PaymentDate { get => paymentDate; set => paymentDate = value; }

        public override string ToString()
        {
            return $"Payment {{ paymentID={paymentID}, courierID={courierID}, amount={amount}, paymentDate={paymentDate} }}";
        }
    }
}
