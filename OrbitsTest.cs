using xunit;
using System;

public class OrbitsTest
{
    [Fact]
    public void Example_input()
    {
//         COM)B
// B)C
// C)D
// D)E
// E)F
// B)G
// G)H
// D)I
// E)J
// J)K
// K)L
        Assert.Equal(42, orbit_counter.Orbits.OrbitCount(map));
    }
}