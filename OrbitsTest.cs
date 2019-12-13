using Xunit;
using System.Collections.Generic;

public class OrbitsTest
{
    
    [Fact]
    public void Example_input()
    {
        string map = "COM)B\nB)C\nC)D\nD)E\nE)F\nB)G\nG)H\nD)I\nE)J\nJ)K\nK)L";
        Assert.Equal(42, orbit_counter.Orbits.OrbitCount(map));
    }

    [Fact]
    public void New_Input()
    {
        string map = "COM)B\nB)C\nB)D\nD)E\nE)F\nC)G\nG)H";
        Assert.Equal(19, orbit_counter.Orbits.OrbitCount(map));
    }

    [Fact]
    public void Puzzle_Input() 
    {
        string map = System.IO.File.ReadAllText(@"./../../input.txt");
        Assert.Equal(100, orbit_counter.Orbits.OrbitCount(map));
    }
}