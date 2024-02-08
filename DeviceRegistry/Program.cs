using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceRegistry
{
    public class Device
    {
        public string PurchaseDate { get; set; }
        public double PurchasePrice { get; set; }
        public int WarrantyMonths { get; set; }

        // Constructor
        public Device(string purchaseDate, double purchasePrice, int warrantyMonths)
        {
            PurchaseDate = purchaseDate;
            PurchasePrice = purchasePrice;
            WarrantyMonths = warrantyMonths;
        }

        // Method to calculate remaining warranty months
        public int RemainingWarrantyMonths()
        {
            DateTime purchaseDateTime = DateTime.Parse(PurchaseDate);
            DateTime now = DateTime.Now;
            DateTime warrantyEnd = purchaseDateTime.AddMonths(WarrantyMonths);
            int remainingMonths = (warrantyEnd - now).Days / 30;
            return Math.Max(0, remainingMonths); // Ensure non-negative value
        }

    }
    // Subclass for computers
    public class Computer : Device
    {
        public string Brand { get; set; }
        public string Processor { get; set; }

        public Computer(string purchaseDate, double purchasePrice, int warrantyMonths, string brand, string processor)
            : base(purchaseDate, purchasePrice, warrantyMonths)
        {
            Brand = brand;
            Processor = processor;
        }
    }

    // Subclass for phones
    public class Phone : Device
    {
        public string Brand { get; set; }
        public string OS { get; set; }

        public Phone(string purchaseDate, double purchasePrice, int warrantyMonths, string brand, string os)
            : base(purchaseDate, purchasePrice, warrantyMonths)
        {
            Brand = brand;
            OS = os;
        }
    }

    // Subclass for tablets
    public class Tablet : Device
    {
        public string Brand { get; set; }
        public string ScreenSize { get; set; }

        public Tablet(string purchaseDate, double purchasePrice, int warrantyMonths, string brand, string screenSize)
            : base(purchaseDate, purchasePrice, warrantyMonths)
        {
            Brand = brand;
            ScreenSize = screenSize;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
