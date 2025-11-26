using System;
using ElectronicsStoreApp;

namespace ElectronicsStoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create store
            ElectronicsStore store = new ElectronicsStore();

            // Create devices
            Laptop myLaptop = new Laptop("Dell", 1200.50);
            Smartphone myPhone = new Smartphone("Samsung", 800.75);

            // Add devices to store
            store.AddDevice(myLaptop);
            store.AddDevice(myPhone);

            // Display all device info and child-specific behavior
            store.ShowAllDeviceDetails();
        }
    }
}
