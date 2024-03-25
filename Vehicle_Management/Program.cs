using System;

class Program
{
    static void Main(string[] args)
    {
        // Create vehicles
        Car car1 = new Car("Accord", "Honda", 2023, 700.00m, 5, "Petrol", "Automatic", false);
        Truck truck1 = new Truck("F-150", "Ford", 2022, 1000.00m, 2, "Pickup", true);
        Motorcycle bike1 = new Motorcycle("Ninja", "Kawasaki", 2020, 300.00m, 1000, "Petrol", true);

        // Display vehicle details
        DisplayVehicleDetails("Car", car1);
        DisplayVehicleDetails("Truck", truck1);
        DisplayVehicleDetails("Motorcycle", bike1);

        // Create a rental agency
        RentalAgency agency = new RentalAgency(3);

        // Add vehicles to the agency
        agency.AddVehicle(car1, 0);
        agency.AddVehicle(truck1, 1);
        agency.AddVehicle(bike1, 2);

        // Rent a vehicle
        RentVehicle(agency, 0);

        // Display total revenue
        Console.WriteLine($"Total Revenue: {agency.TotalRevenue:C}");
    }

    // Method to display vehicle details
    static void DisplayVehicleDetails(string vehicleType, Vehicle vehicle)
    {
        Console.WriteLine($"{vehicleType} Details:");
        vehicle.DisplayDetails();
        Console.WriteLine();
    }

    // Method to rent a vehicle
    static void RentVehicle(RentalAgency agency, int index)
    {
        Console.WriteLine($"Renting vehicle at index {index}:");
        agency.RentVehicle(index);
        Console.WriteLine();
    }
}
