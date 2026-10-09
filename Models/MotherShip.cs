namespace Starship_Mini.Models;

// has-a relationship
// 1 Mothership has n Basehips
public class MotherShip
{
    private const int MAX_SHIPS = 10;
    
    // private List<BaseShip> _baseShips = new List<BaseShip>();
    // Invariants: [0, 10], no duplicates
    private List<BaseShip> _baseShips = [];

    public IReadOnlyList<BaseShip> BaseShips => _baseShips.AsReadOnly();

    // Dock
    public void Dock(BaseShip baseShip)
    {
        ArgumentNullException.ThrowIfNull(baseShip);
        ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual(BaseShips.Count, MAX_SHIPS);

        // For each element in the BaseShip List
        //  take the list element and call the equals to compare the list elem with the param
        if (BaseShips.Contains(baseShip))
            throw new ArgumentException("Baseship is already in the list");
        
        _baseShips.Add(baseShip);
    }
    
    // UnDock
    public void UnDock(BaseShip baseShip)
    {
        ArgumentNullException.ThrowIfNull(baseShip);

        // For each element in the BaseShip List
        //  take the list element and call the equals to compare the list elem with the param
        if (!BaseShips.Contains(baseShip))
            throw new ArgumentException("BaseShip is not in the list");
        
        _baseShips.Remove(baseShip);
    }
    
    
    // JavaScript: for (let baseship of baseships) {}
    // Java: for (var basehip : baseships) {}
    // C#: foreach (var basehip in basehips) {}
    
    // Imperative Version
    // Return the total number of crew members on all docked ships.
    public int SumCrewMembers_Imp()
    {
        int sum = 0;

        // type inferring
        // foreach (BaseShip baseship in BaseShips)
        // foreach (var foobar in new List<int>() { 1, 2, 3 } )
        foreach (var baseship in BaseShips )
        {
            sum += baseship.CrewMembers;
        }

        return sum;
    }
    
    // Declarative
    public int SumCrewMembers_Dec()
    {
        // (spaceship) -> int
        // int sum = BaseShips.Sum(baseship => baseship.CrewMembers);
        // return sum;
        
        return BaseShips.Sum(baseship => baseship.CrewMembers);
    }
    
    // Return how many ships have more crew members than `limit`.
    public int NumberLargeCrew(int limit)
    {
        // Baseship 1: 5 Crews
        // Baseship 2: 8 Crews
        // Baseship 3: 2 Crews
        
        // NumberLargeCrew(4) -> 2
    }
}