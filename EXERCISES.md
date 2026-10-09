# Starships-Mini: LINQ vs imperative

## Warm-up

### Ex 1: Dock on
Add a ship to the mothership. Invariants: not null, max 10 ships, no duplicates (`Equals`).
`void DockOn(BaseShip baseship)`

### Ex 2: Dock off
Remove a ship from the mothership. Invariants: not null.
`void DockOff(BaseShip baseship)`

### Ex 3: Sum crew members
Return the total number of crew members on all docked ships.
`int SumCrewMembers()`

### Ex 4: Number of large crews
Return how many ships have more crew members than `limit`.
`int NumberLargeCrew(int limit)`

### Ex 5: Large ships
Return all ships with more crew members than `limit`.
`IReadOnlyList<BaseShip> LargeShips(int limit)`

---

## Easy

### Ex 6: Captain only
Return how many ships have only a captain on board.
`int CountCaptainOnly()`

### Ex 7: Any full ship
Return `true` if at least one ship is full.
`bool AnyShipFull()`

### Ex 8: Minimum crew
Return `true` if every ship has at least `min` crew members.
`bool AllHaveMinCrew(int min)`

### Ex 9: Smallest crew
Return the smallest number of crew members of any ship.
`int SmallestCrew()`

### Ex 10: Largest crew
Return the largest number of crew members of any ship.
`int LargestCrew()`

### Ex 11: Oldest ship
Return the build date of the oldest ship.
`DateOnly OldestBuildDate()`

### Ex 12: Ship names
Return the names of all ships.
`IReadOnlyList<string> ShipNames()`

### Ex 13: Built after
Return all ships built after `date`.
`IReadOnlyList<BaseShip> BuiltAfter(DateOnly date)`

### Ex 14: Sorted by name
Return all ships sorted by name (A to Z).
`IReadOnlyList<BaseShip> SortedByName()`

### Ex 15: Is docked
Return `true` if a ship with the given name is docked.
`bool IsDocked(string name)`

---

## Medium

### Ex 16: Names of full ships
Return the names of all full ships.
`IReadOnlyList<string> FullShipNames()`

### Ex 17: Crew of old ships
Return the total crew of all ships built before `date`.
`int CrewBuiltBefore(DateOnly date)`

### Ex 18: Names by crew size
Return the names of all ships, largest crew first.
`IReadOnlyList<string> NamesByCrewDescending()`

### Ex 19: Ships per crew size
Return how many ships exist for each crew size, as `(CrewMembers, Count)` pairs.
`IReadOnlyList<(int CrewMembers, int Count)> ShipsPerCrewSize()`

### Ex 20: New ships are full
Return `true` if every ship built in `year` is full.
`bool AllNewShipsFull(int year)`

---

## Hard

### Ex 21: Full ships, newest first
Return the names of all full ships, newest build date first.
`IReadOnlyList<string> FullShipNamesNewestFirst()`

### Ex 22: Crew per build year
Return the total crew for each build year, sorted by year, as `(Year, Crew)` pairs.
`IReadOnlyList<(int Year, int Crew)> CrewPerYear()`

### Ex 23: Ready to fight
Return the names of all starships that can fight.
`IReadOnlyList<string> ReadyToFight()`
