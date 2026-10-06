// See https://aka.ms/new-console-template for more information

using Starship_Mini.Models;

// Starship starship1 = new Starship("Bounty", 8, new DateOnly(2026, 1, 1));
// BaseShip starship1 = new Starship("Bounty", 8, new DateOnly(2026, 1, 1));

// Object Initializer Syntax
Starship starship2 = new Starship() // 1000
{
    Name = "Bounty",
    CrewMembers = 8,
    BuildAt = new DateOnly(2026, 1, 1),
    IsBattleShip =  true,
};

// Object Initializer Syntax
Starship starship3 = new Starship() // 2000
{
    Name = "Bounty",
    CrewMembers = 8,
    BuildAt = new DateOnly(2026, 1, 1),
    IsBattleShip =  true,
};

Starship starship4 = starship3;

// referential equality
Console.WriteLine(starship2 == starship3); // referential equality
Console.WriteLine(starship2.Equals(starship3)); // structural equality
// Console.WriteLine(starship3 == starship4); // true


// var mothership = new Mothership();
// mothership.DockOn(starship1);
// mothership.DockOn(starship2);
// mothership.Baseships.Clear(); // coz of IReadOnlyList

// foreach (var ship in mothership.Baseships)
// {
    // Console.WriteLine(ship);
// }


// Console.WriteLine(starship1);
// Console.WriteLine(starship2);