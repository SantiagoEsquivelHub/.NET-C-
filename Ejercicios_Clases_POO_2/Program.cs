#region 

using Ejercicios_Clases_POO_2;

List<Vehicle> vehicles = new List<Vehicle>();

Car car = new Car(12345, 4, 4);
vehicles.Add(car);

Boat boat = new Boat(67890, 0, 0);
vehicles.Add(boat);

Plane plane = new Plane(22222, 6, 3);
vehicles.Add(plane);

foreach (var vehicle in vehicles)
{
    vehicle.GetSalute();
}

#endregion
