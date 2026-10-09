// See https://aka.ms/new-console-template for more information

using Starship_Mini.Models;

// Starship starship1 = new Starship("Bounty", 8, new DateOnly(2026, 1, 1));
BaseShip starship1 = new Starship("Bounty", 8, new DateOnly(2026, 1, 1))
{
    IsBattleShip = true
};

// Object Initializer Syntax
Starship starship2 = new Starship()
{
    Name = "Bounty",
    CrewMembers = 9,
    BuildAt = new DateOnly(2026, 1, 1),
    IsBattleShip =  true,
};


// Object Initializer Syntax
Starship starship3 = new Starship()
{
    Name = "Bounty",
    CrewMembers = 8,
    BuildAt = new DateOnly(2026, 1, 1),
    IsBattleShip =  false,
};

Console.WriteLine(starship2 == starship3); // dasselbe
Console.WriteLine(starship2.Equals(starship3)); // das Gleiche

var mothership = new MotherShip();
// mothership._baseShips.Add(starship1);
// mothership._baseShips.Clear();
