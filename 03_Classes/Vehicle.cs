﻿namespace
    _3_Classes
{
    public enum VehicleType { Car, Truck, Motorcycle, Spaceship, SUV, Tractor, Boat, FlyingBison }
    public class Vehicle
    {
        //1 Access Modifier 
        //2 Type 
        //3 Name 
        //4 Getters and Setters 
        public string Make { get; set; }
        public string Model { get; set; }
        public double Mileage { get; set; }
        public VehicleType TypeOfVehicle { get; set; }
    }
}