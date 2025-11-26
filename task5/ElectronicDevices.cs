using System;
using System.Collections.Generic;

namespace ElectronicsStoreApp
{
    // Abstract class
    public abstract class ElectronicDevice
    {
        private string brand;
        private double price;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        protected ElectronicDevice(string brand, double price)
        {
            this.brand = brand;
            this.price = price;
        }

        public abstract void ShowInfo();
    }

    // Derived class Laptop
    public class Laptop : ElectronicDevice
    {
        public Laptop(string brand, double price) : base(brand, price) { }

        public void TurnOnBattery()
        {
            Console.WriteLine("Laptop battery turned on.");
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Laptop - Brand: {Brand}, Price: ${Price}");
        }
    }

    // Derived class Smartphone
    public class Smartphone : ElectronicDevice
    {
        public Smartphone(string brand, double price) : base(brand, price) { }

        public void EnableCamera()
        {
            Console.WriteLine("Smartphone camera enabled.");
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Smartphone - Brand: {Brand}, Price: ${Price}");
        }
    }

    // ElectronicsStore class
    public class ElectronicsStore
    {
        private List<ElectronicDevice> devices = new List<ElectronicDevice>();

        public void AddDevice(ElectronicDevice device)
        {
            devices.Add(device);
            Console.WriteLine($"{device.Brand} added to the store.");
        }

        public void RemoveDevice(ElectronicDevice device)
        {
            if (devices.Remove(device))
                Console.WriteLine($"{device.Brand} removed from the store.");
            else
                Console.WriteLine($"{device.Brand} not found in the store.");
        }

        public void ShowAllDeviceDetails()
        {
            Console.WriteLine("\n--- All Device Details ---");
            foreach (var device in devices)
            {
                device.ShowInfo();

                // Downcast to call child-specific methods
                if (device is Laptop laptop)
                {
                    laptop.TurnOnBattery();
                }
                else if (device is Smartphone phone)
                {
                    phone.EnableCamera();
                }

                Console.WriteLine();
            }
        }
    }
}
