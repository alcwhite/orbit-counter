using Xunit;
using System.Collections.Generic;

public class OrbitsTest
{
    string map = "COM)B\nB)C\nC)D\nD)E\nE)F\nB)G\nG)H\nD)I\nE)J\nJ)K\nK)L";
    [Fact]
    public void Example_input()
    {
        Assert.Equal(42, orbit_counter.Orbits.OrbitCount(map));
    }
}