namespace Starship_Mini.Models;

public abstract class BaseShip : Object
{
        // Single Source of Truth
    // Java Version: private final int MAX_CREW_CAPACITY = 10;
    private const int MaxCrewCapacity = 10;
    
    
    // --- Backing Fields ----
    
    private string _name;
    
    private DateOnly _buildAt;
    
    private int _crewMembers;
    
    
    // --- Properties ---
    
    // Invariants: crewMembers = 10
    // IsShipFull
    public bool IsShipFull => CrewMembers == MaxCrewCapacity;
    
    // Invariants: crewMembers = 1
    // Computed Property as Lambda Expression Body
    public bool HasShipOnlyCaptain => CrewMembers == 1;
    
    // Computed Property as Function Body
    // public bool HasShipOnlyCaptain
    // {
        // get
        // {
            // return CrewMembers == 1;
        // }
    // }

    // Method as Lamba Expression Body
    // public bool HasShipOnlyCaption() => CrewMembers == 1;
    
    // Method as Function Body
    // public bool HasShipOnlyCaption()
    // {
        // return CrewMembers == 1;
    // }
    
    // Invariants: [1, 10]
    // crewMembers: int
    public int CrewMembers
    {
        get { return _crewMembers; }

        set
        {
            // Guard
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(value, nameof(CrewMembers));
            ArgumentOutOfRangeException.ThrowIfGreaterThan(value, MaxCrewCapacity, nameof(CrewMembers));

            _crewMembers = value;
        }
        
        
    }
    
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
            DateOnly minDate = nowDate.AddYears(-MaxCrewCapacity);
            
            ArgumentOutOfRangeException.ThrowIfLessThan(value, minDate);
            ArgumentOutOfRangeException.ThrowIfGreaterThan(value, nowDate);

            _buildAt = value;
        }
    }
    
    public BaseShip() {}

    public BaseShip(string name, int crewMembers, DateOnly buildAt)
    {
        Name = name;
        BuildAt = buildAt;
        CrewMembers = crewMembers;
    }

    protected bool Equals(BaseShip other)
    {
        return _name == other._name;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != GetType()) return false;
        return Equals((BaseShip)obj);
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