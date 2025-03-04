﻿// Author: Michael Baker
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Display and practice using Inheritance between classes
namespace COMP003A.LectureActivity6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a Vehicle object with brand and year
            Vehicle myVehicle = new Vehicle { Brand = "Toyota", Year = 2020 };
            // Create a Car object with brand, year, and number of doors
            Car myCar = new Car("Honda", 2022, 4);

            // Display vehicle details
            myVehicle.DisplayInfo();
            // Display car details
            myCar.DisplayInfo();
        }
    }
}
