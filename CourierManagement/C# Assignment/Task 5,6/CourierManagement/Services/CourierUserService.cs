using System.Collections.Generic;
using Entities;

namespace Services
{
    public class CourierUserService : ICourierUserService
    {
        private List<Courier> couriers = new List<Courier>();

        public string PlaceOrder(Courier courierObj)
        {
            couriers.Add(courierObj);
            return courierObj.UniqueTrackingNumber.ToString();
        }

        public string GetOrderStatus(long trackingNumber)
        {
            foreach (var courier in couriers)
            {
                if (courier.UniqueTrackingNumber == trackingNumber)
                {
                    return courier.Status;
                }
            }
            return "Tracking number not found.";
        }

        public bool CancelOrder(long trackingNumber)
        {
            foreach (var courier in couriers)
            {
                if (courier.UniqueTrackingNumber == trackingNumber)
                {
                    // Logic to cancel the order
                    courier.Status = "Canceled";
                    return true;
                }
            }
            return false;
        }

        public List<Courier> GetAssignedOrder(int courierStaffId)
        {
            // Assuming courierStaffId is part of the Courier or User class in a real application
            // For simplicity, returning all couriers
            return couriers;
        }
    }
}
