namespace Starship_Mini.Models;

public abstract class BaseShip
{
    private int _crewMembers;
    
    // Invariants: [1, 10]
    // crewMembers: int
    public int CrewMembers
    {
        get { return _crewMembers; }

        set
        {
            // Guard
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(value, nameof(CrewMembers));
            ArgumentOutOfRangeException.ThrowIfGreaterThan(value, 10, nameof(CrewMembers));

            _crewMembers = value;
        }
        
        
    }
    
    // 1 virtual method

    public BaseShip(int crewMembers)
    {
        CrewMembers = crewMembers;
    }
    
    public BaseShip() {}
    
        
}