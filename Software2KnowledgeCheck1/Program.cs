using Software2KnowledgeCheck1;

var city = new City();
city.Name = "Shively";
city.State = "Kentucky";
city.ZipCode = 40216;
city.Population = 15710;

var apartment1 = new Apartment();

apartment1.StreetNumber = 100;
apartment1.Street = "Dixie Hwy";
apartment1.NumberOfOpenUnits = 20;
apartment1.NumberOfOpenUnits = 10;
apartment1.HasParking = true;

var apartment2 = new Apartment();

apartment2.StreetNumber = 120;
apartment2.Street = "Crums Ln";
apartment2.NumberOfOpenUnits = 25;
apartment2.NumberOfOpenUnits = 5;
apartment2.HasParking = true;


var higRise1 = new HighRise();

higRise1.Street = "Dixie Hwy";
higRise1.StreetNumber = 5000;
higRise1.NumberOfStories = 110;
higRise1.OwnerName = "John Doe";
higRise1.Directory = new List<string> { "001- Offices", "002- Apartments", "003- Restaurants" };


BuildingConstruction<Apartment> buildingConstruction = new BuildingConstruction<Apartment>();

city.Buildings.Add(buildingConstruction.CreateBuilding<Apartment>(apartment1));
city.Buildings.Add(buildingConstruction.CreateBuilding<Apartment>(apartment2));
city.Buildings.Add(buildingConstruction.CreateBuilding<HighRise>(higRise1));




city.Buildings.ForEach((building => 
{
    Console.WriteLine($"Address: {building.StreetNumber} {building.Street}");
}));

Console.ReadLine();

//output
//     Address: 100 Dixie Hwy
//     Address: 120 Crums Ln
//     Address: 5000 Dixie Hwy