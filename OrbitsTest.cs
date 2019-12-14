using Xunit;
using System.Collections.Generic;
using System.IO;

public class OrbitsTest
{
    string map = @"C:\Users\theth\Desktop\Practice\orbit-counter\input.txt";
    string testMap = @"C:\Users\theth\Desktop\Practice\orbit-counter\testInput.txt";
    string originalTestMap = @"C:\Users\theth\Desktop\Practice\orbit-counter\originalTestInput.txt";
    [Fact]
    public void Puzzle_Input_All_Count() 
    {
        Assert.Equal(130681, orbit_counter.Orbits.OrbitCount(map));
    }
    [Fact]
    public void Test_Input_All_Count() 
    {
        Assert.Equal(42, orbit_counter.Orbits.OrbitCount(originalTestMap));
    }
    [Fact]
    public void Puzzle_Input_Santa_Count() 
    {
        Assert.Equal(313, orbit_counter.Orbits.YouToSantaCount(map));
    }
    [Fact]
    public void Test_Input_Santa_Count() 
    {
        Assert.Equal(4, orbit_counter.Orbits.YouToSantaCount(testMap));
    }
}