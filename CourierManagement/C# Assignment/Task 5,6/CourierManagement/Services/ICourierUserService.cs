using System.Collections.Generic;
using Entities;

namespace Services
{
    public interface ICourierUserService
    {
        string PlaceOrder(Courier courierObj);
        string GetOrderStatus(long trackingNumber);
        bool CancelOrder(long trackingNumber);
        List<Courier> GetAssignedOrder(int courierStaffId);
    }
}
