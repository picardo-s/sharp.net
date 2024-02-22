using Packt.Shared;

/*Person bob = new Person();

bob.Name = "Bob Smith";
bob.DateOfBirth = new DateTime(1965, 12, 22);
bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
bob.Children.Add(new Person { Name = "Alfred" });
bob.Children.Add(new() { Name = "Zoe" });

WriteLine(format: $"{bob.Name} was born on {bob.DateOfBirth:dddd, d MMMM yyyy}");
WriteLine($"{bob.Name}'s favorite wonder is {bob.FavoriteAncientWonder}. Its integer is {(int)bob.FavoriteAncientWonder}");
WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");
WriteLine($"{bob.Name} has {bob.Children.Count} children:");

for(int childIndex = 0; childIndex < bob.Children.Count; childIndex++)
{
    WriteLine($"> {bob.Children[childIndex].Name}");
}

Person alice = new()
{
    Name = "Alice Jones",
    DateOfBirth = new(1998, 3, 7)
};

WriteLine(format: $"{alice.Name} was born on {alice.DateOfBirth:dd MMM yy}");

Person blankPerson = new();

WriteLine($"{blankPerson.Name} of {blankPerson.HomePlanet} was created at {blankPerson.Instantiated:hh:mm:ss:dddd}");
(string name, int number) = bob.GetFruit();
WriteLine($"{name}, {number} there are");

var fruitNamed = bob.GetNamedFruit();
WriteLine($"There are {fruitNamed.Number} {fruitNamed.Name}");

var (name1, dob1) = bob;
WriteLine($"Deconstructed: {name1}, {dob1}");

var (name2, dob2, fav2) = bob;
WriteLine($"Deconstructed: {name2}, {dob2}, {fav2}");

int a = 10;
int b = 20;
WriteLine($"Before: a = {a}, b = {b}");
bob.PassingParameters(a, ref b, out int c);
WriteLine($"After: a = {a}, b = {b}, c = {c}");

Person sam = new()
{
    Name = "Sam",
    DateOfBirth = new(1969, 6, 25)
};
WriteLine(sam.Origin);
WriteLine(sam.Greeting);
WriteLine(sam.Age);
sam.FavoriteIceCream = "Panna-Cotta";
WriteLine(sam.FavoriteIceCream);

string color = "Orange";
try
{
    sam.FavoritePrimaryColor = color;
    WriteLine($"Sam's favorite primary color is {sam.FavoritePrimaryColor}");
}
catch(Exception ex)
{
    WriteLine($"Tried to set {nameof(sam.FavoritePrimaryColor)}, to {color}: {ex.Message}");
}*/

/*Book book = new()
{
    Isbn = "123-123123123",
    Title = "Qwasdzxcv"
};*/
/*Book book = new("123-123123123", "Qwasdzxcv")
{
    Author = "Me",
    PageCount = 123
};

WriteLine($"{book.Isbn}: {book.Title} written by {book.Author} has {book.PageCount:N0} pages");

sam.Children.Add(new() { Name = "Charlie", DateOfBirth = new(2010, 3, 18)});
sam.Children.Add(new() { Name = "Ella", DateOfBirth = new(2020, 12, 24)});

WriteLine($"Sam's first child is {sam[0].Name}.");
WriteLine($"Sam's second child is {sam[1].Name}.");

WriteLine($"Sam's child names Ella is {sam["Ella"].Age} years old.");

Person lamech = new() { Name = "Lamech" };
Person adah = new() { Name = "Adah" };
Person zillah = new() { Name = "Zillah" };

lamech.Marry(adah);
//Person.Marry(zillah, lamech);
if(zillah + lamech)
{
    WriteLine($"{zillah.Name} and {lamech.Name} successfully got married.");
}

WriteLine($"{lamech.Name} is married to {lamech.Spouse?.Name}");
WriteLine($"{adah.Name} is married to {adah.Spouse?.Name}");
WriteLine($"{zillah.Name} is married to {zillah.Spouse?.Name}");

Person baby1 = lamech.ProcreateWith(adah);
baby1.Name = "Jabal";
WriteLine($"{baby1.Name} was born on {baby1.DateOfBirth}");

Person baby2 = Person.Procreate(zillah, lamech);
baby2.Name = "Tubalcain";

Person baby3 = lamech * adah;
baby3.Name = "Jubal";

Person baby4 = zillah * lamech;
baby4.Name = "Naamah";

WriteLine($"{lamech.Name} has {lamech.Children.Count} children.");
WriteLine($"{adah.Name} has {adah.Children.Count} children.");
WriteLine($"{zillah.Name} has {zillah.Children.Count} children.");

for(int i = 0; i < lamech.Children.Count; i++)
{
    WriteLine($"{lamech.Name}'s child #{i} is named \"{lamech[i].Name}\"");
}

/*int number = 5;
try
{
    WriteLine($"{number}! is {Person.Factorial(number)}");
}
catch(Exception ex)
{
    WriteLine($"{ex.GetType()} says: {ex.Message} number was {number}.");
}*/

Passenger[] passengers = {
    new FirstClassPassenger { AirMiles = 1_419, Name = "Suman" },
    new FirstClassPassenger { AirMiles = 16_562, Name = "Lucy"},
    new BusinessClassPassenger { Name = "Janice"},
    new CoachClassPassenger { CarryOnKG = 25.7, Name = "Dave "},
    new CoachClassPassenger { CarryOnKG = 0, Name = "Amit" }
};

foreach (Passenger passenger in passengers)
{
    decimal flightCost = passenger switch
    /*{
        FirstClassPassenger p when p.AirMiles > 35000 => 1500M,
        FirstClassPassenger p when p.AirMiles > 15000 => 1750M,
        FirstClassPassenger _ => 2000M,
        BusinessClassPassenger _ => 1000M,
        CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
        CoachClassPassenger _ => 650M,
        _ => 800M
    };*/
    {
        FirstClassPassenger p => p.AirMiles switch
        {
            > 35000 => 1500M,
            > 15000 => 1750M,
            _       => 2000M
        },
        BusinessClassPassenger => 1000M,
        CoachClassPassenger { CarryOnKG: < 10.0 } => 500M,
        CoachClassPassenger                       => 650M,
        _                                         => 800M
    };
    WriteLine($"Flight costs {flightCost:C} for {passenger}");
}

ImmutablePerson jeff = new()
{
    FirstName = "Jeff",
    LastName = "Winger"
};
//jeff.FirstName = "Geoff";

ImmutableVehicle car = new()
{
    Brand = "Mazda MX-5 RF",
    Color = "Soul Red Crystal Metallic",
    Wheels = 4
};

ImmutableVehicle repaintedCar = car with { Color = "Polymetal Grey Metallic" };
WriteLine($"Original car color was {car.Color}.");
WriteLine($"New car color is {repaintedCar.Color}.");

ImmutableAnimal oscar = new("Oscar", "Labrador");
var (who, what) = oscar;
WriteLine($"{who} is a {what}");