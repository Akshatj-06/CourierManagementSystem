using System;
using Entities;
using Services;

namespace CourierManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            ICourierUserService userService = new CourierUserService();
            ICourierAdminService adminService = new CourierAdminService();

            // Create and add a new courier staff
            Employee employee = new Employee(1, "John Doe", "john@example.com", "1234567890", "Courier", 3000);
            adminService.AddCourierStaff(employee);

            // Create a new courier order
            Courier courier = new Courier(1, "Alice", "123 Main St", "Bob", "456 Elm St", 5.0, "Yet to transit", DateTime.Now.AddDays(2), 1);
            string trackingNumber = userService.PlaceOrder(courier);

            // Get order status
            Console.WriteLine($"Tracking Number: {trackingNumber}");
            Console.WriteLine($"Order Status: {userService.GetOrderStatus(courier.UniqueTrackingNumber)}");

            // Cancel the order
            bool canceled = userService.CancelOrder(courier.UniqueTrackingNumber);
            Console.WriteLine($"Order Canceled: {canceled}");
            Console.WriteLine($"Updated Order Status: {userService.GetOrderStatus(courier.UniqueTrackingNumber)}");
        }
    }
}
