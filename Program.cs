// See https://aka.ms/new-console-template for more information

using Starship_Mini.Models;

// var starship = new Starship("Bounty", 8, new DateOnly(2026, 1, 1));

// Object Initializer Syntax
var starship = new Starship()
{
    Name = "Bounty",
    CrewMembers = 8,
    BuildAt = new DateOnly(2026, 1, 1),
    IsBattleShip =  true,
};

Console.WriteLine(starship);