using AM.Core.Domain;

Plane plane= new Plane() { Capacity= 35, PlaneId=3, MyPlaneType = PlaneType.Airbus, ManufactureDate= new DateTime(2023,02,17)};
Plane plane1 = new Plane(PlaneType.Boeing, 54, new DateTime(2032,4,20));

Passenger passenger1 = new Passenger() { EmailAddress = "farouk@gmail.com"  };
Staff staff = new Staff() { EmailAddress = "farouk@gmail.com" };
Traveller traveller = new Traveller() { EmailAddress = "farouk@gmail.com" };

Console.WriteLine(passenger1.GetPassengerType());
Console.WriteLine(staff.GetPassengerType());
Console.WriteLine(traveller.GetPassengerType());
int calculatedAge = 0;
passenger1.GetAge(new DateTime(2000, 1, 1), ref calculatedAge);
Console.WriteLine(calculatedAge);
passenger1.BirthDate = new DateTime(2000, 1, 1);
//passenger1.GetAge(passenger1);
