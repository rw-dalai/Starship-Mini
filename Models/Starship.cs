using System.ComponentModel.DataAnnotations;
using System.Net.WebSockets;

namespace Starship_Mini.Models;


// is-a relationship

// Idiomatic C#
public class Starship : BaseShip
{
    // --- Backing Fields ----
    
    private string _name;
    
    private DateOnly _buildAt;
    
    
    // --- Properties ---
    
    public bool IsBattleShip { get; set; }

    // Invariants: not null, not empty, should be trimmed
    // name: string
    public string Name
    {
        get { return _name; }
        set
        {
            // FAIL FAST
            // if (string.IsNullOrEmpty(value))
            // {
            //     throw new ArgumentException("Name should not be empty");
            // }
            
            // GUARD
            ArgumentException.ThrowIfNullOrWhiteSpace(value, nameof(Name));
            // Require.NotNullNotWhiteSpace(value);
            _name = value.Trim();
        }
        
    }
    
    // Invariants: [date.now - 10 years, now]
    // buildAt: DateOnly


    public DateOnly BuildAt
    {
        get { return _buildAt; }

        set
        {
            // [2016, 2026]
            DateTime now = DateTime.UtcNow; // Zulu Time, ISO 8610
            
            DateOnly nowDate = DateOnly.FromDateTime(now);
            DateOnly minDate = nowDate.AddYears(-10);
            
            ArgumentOutOfRangeException.ThrowIfLessThan(value, minDate);
            ArgumentOutOfRangeException.ThrowIfGreaterThan(value, nowDate);

            _buildAt = value;
        }
    }
    
    // --- Ctor ---
    
    public Starship(string name, int crewMembers, DateOnly buildAt) 
        : base(crewMembers)
    {
        Name = name;
        BuildAt = buildAt;
    }

    public Starship() 
        : base()
    {
    }
    
    
    // --- Equals ---

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != GetType()) return false;
        Starship starship = (Starship)obj;
        return Equals(starship);
        
    }

    protected bool Equals(Starship other)
    {
        return Name == other.Name;
    }

    public override int GetHashCode()
    {
        return _name.GetHashCode();
    }


    // --- To String ---
    
    public override string ToString()
    {
        return $"Name: {Name}, CrewMembers: {CrewMembers}, BuildAt: {BuildAt}";
    }
}