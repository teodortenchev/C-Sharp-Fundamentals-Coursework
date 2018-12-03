﻿namespace Vehicles.Models
{
    class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption + 1.6)
        {
        }

        public override void Refuel(double liters)
        {
            base.Refuel(liters);
            FuelQuantity -= FuelQuantity * 0.05;
        }
    }
}