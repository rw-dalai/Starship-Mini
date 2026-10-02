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


    
    
    // Invariants: not null, no duplicates, [0, 10]
    // add
    public void DockOn(BaseShip baseship)
    {
        // FAIL FAST ...
        
        _baseships.Add(baseship);
    }
    
    
    // remove
    
    
    // find
}