using System.ComponentModel.DataAnnotations;
using System.Net.WebSockets;

namespace Starship_Mini.Models;


// is-a relationship
// has-a relationship

// Idiomatic C#
public class Starship : BaseShip
{
    // TODO
    
    // --- Ctor ---

    public Starship() 
        : base()
    {
    }

    public Starship(string name, int crewMembers, DateOnly buildAt) 
        : base(name, crewMembers, buildAt)
    {
    }
}