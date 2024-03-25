public class RentalAgency
{
    // Array to store vehicles
    private Vehicle[] Fleet { get; set; }

    // Property to track total revenue
    public decimal TotalRevenue { get; private set; }

    // Constructor
    public RentalAgency(int fleetSize)
    {
        Fleet = new Vehicle[fleetSize];
        TotalRevenue = 0;
    }

    // Method to add vehicle to the fleet
    public void AddVehicle(Vehicle vehicle, int index)
    {
        Fleet[index] = vehicle;
    }

    // Method to remove vehicle from the fleet
    public void RemoveVehicle(int index)
    {
        Fleet[index] = null;
    }

    // Method to rent a vehicle
    public void RentVehicle(int index)
    {
        if (Fleet[index] != null)
        {
            TotalRevenue += Fleet[index].RentalPrice;
            Console.WriteLine($"Vehicle rented: {Fleet[index].Manufacturer} {Fleet[index].Model}");
            Fleet[index] = null;
        }
        else
        {
            Console.WriteLine("Vehicle not available for rent.");
        }
    }
}