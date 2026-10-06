namespace Starship_Mini.Models;

// is-a relationship
// has-a relationship (1:n)
public class Mothership
{
    // --- Backing Field ---
    
    // internal mutable list
    // private List<BaseShip> _baseships = new List<BaseShip>();
    private List<BaseShip> _baseships = [];

    // exposed as read only
    public IReadOnlyList<BaseShip> Baseships => _baseships.AsReadOnly();

    
    // Invariants: not null, size [0, 10], names are unique
    // add
    public void DockOn(BaseShip baseship)
    {
        ArgumentNullException.ThrowIfNull(baseship);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(Baseships.Count, 10);
        
        if (Baseships.Contains(baseship))
            throw new ArgumentException("Cannot contain duplicates");
        
        _baseships.Add(baseship);

    }
    
    // remove
    public void DockOff(BaseShip baseship)
    {
        ArgumentNullException.ThrowIfNull(baseship);
        
        _baseships.Remove(baseship);
    }
    
    
    // sum all crew members
    // public int SumCrewMembers()
    // {
    //     int total = 0;
    //
    //     foreach (BaseShip baseship in Baseships)
    //     {
    //         total += baseship.CrewMembers;
    //     }
    //
    //     return total;
    // }
    
    public int SumCrewMembers()
    {
        return Baseships.Sum(baseship => baseship.CrewMembers);
    }
    
    
    // imperative programming (how i do it)
    
    // public int NumberLargeCrew(int limit)
    // {
    //     int count = 0;
    //     
    //     foreach (BaseShip baseShip in Baseships)
    //     {
    //         if (baseShip.CrewMembers > limit)
    //         {
    //             count++;
    //         }
    //     }
    //
    //     return count;
    // }
    
    
    // declarative programming (what i want)
    
    public int NumberLargeCrew(int limit)
    {
        // SQL WHERE
        // Java filter, JavaScript filter
        // int count = _baseships
            // .Where(baseship => baseship.CrewMembers > limit)
            // .Count();

        return _baseships.Count(baseship => baseship.CrewMembers > limit);
    }

    // public IReadOnlyList<BaseShip> NumberLargeShips(int limit)
    // {
    //     List<BaseShip> largerShips = [];
    //         
    //     foreach (BaseShip baseShip in Baseships)
    //     {
    //         if (baseShip.CrewMembers > limit)
    //         {
    //             largerShips.Add(baseShip);
    //         }
    //     }
    //     
    //     return largerShips.AsReadOnly();
    // }
    
    
    // declarative
    // LINQ, where, toList, 
    
    public IReadOnlyList<BaseShip> NumberLargeShips(int limit)
    {
        return _baseships
            .Where(baseship => baseship.CrewMembers > limit)
            .ToList();
    }

}