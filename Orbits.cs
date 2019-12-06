using System;
using System.Collections.Generic;
using System.Linq;
using System.String.Split;

namespace orbit_counter
{
    public static class Orbits
    {
        public static int OrbitCount(string map)
        {
            int links = 0;
            var parsedMap = new Dictionary<char, string>();
            map.Select(orbit => {
                orbit.Split([')'], 2, StringSplitOptions.None);
            });
            return links;
        }
    }
}