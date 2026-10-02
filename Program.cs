// See https://aka.ms/new-console-template for more information

using Starship_Mini.Models;

// Starship starship1 = new Starship("Bounty", 8, new DateOnly(2026, 1, 1));
BaseShip starship1 = new Starship("Bounty", 8, new DateOnly(2026, 1, 1));

// Object Initializer Syntax
Starship starship2 = new Starship()
{
    Name = "Bounty",
    CrewMembers = 8,
    BuildAt = new DateOnly(2026, 1, 1),
    IsBattleShip =  true,
};


var mothership = new Mothership();
mothership.DockOn(starship1);
mothership.DockOn(starship2);
// mothership.Baseships.Clear();

foreach (var ship in mothership.Baseships)
{
    Console.WriteLine(ship);
}


// Console.WriteLine(starship1);
// Console.WriteLine(starship2);