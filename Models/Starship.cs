using System.ComponentModel.DataAnnotations;
using System.Net.WebSockets;

namespace Starship_Mini.Models;


// is-a relationship

// Idiomatic C#
public class Starship : BaseShip
{
    // --- Backing Fields ----
    
    private string _name;
    
    private int _crewMembers;

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
    
    
    // Invariants: [1, 10]
    // crewMembers: int
    public int CrewMembers
    {
        get { return _crewMembers; }

        set
        {
            // FAIL FAST
            // if (value < 1 || value > 10)
            // {
            //     throw new ArgumentOutOfRangeException(
            //         "Amount of Crew Member should between 1 and 10 ");
            // }
            
            // Guard
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(value, nameof(CrewMembers));
            ArgumentOutOfRangeException.ThrowIfGreaterThan(value, 10, nameof(CrewMembers));

            _crewMembers = value;
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
        : base()
    {
        Name = name;
        CrewMembers = crewMembers;
        BuildAt = buildAt;
    }

    public Starship() 
        : base()
    {
    }

    // --- Misc ---
    
    public override string ToString()
    {
        return $"Name: {Name}, CrewMembers: {CrewMembers}, BuildAt: {BuildAt}";
    }
}