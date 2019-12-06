using xunit;
using System;

public class OrbitsTest
{
    [Fact]
    public void Example_input()
    {
        var map = new List<string>();
        map.Add("COM)B");
        map.Add("B)C");
        map.Add("C)D");
        map.Add("D)E");
        map.Add("E)F");
        map.Add("B)G");
        map.Add("G)H");
        map.Add("D)I");
        map.Add("E)J");
        map.Add("J)K");
        map.Add("K)L");
        
        Assert.Equal(42, orbit_counter.Orbits.OrbitCount(map));
    }
}