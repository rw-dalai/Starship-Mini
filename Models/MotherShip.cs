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
    
    // Imperative Version
    // Return the total number of crew members on all docked ships.
    // public int SumCrewMembers()
    // {
        
    // }
}