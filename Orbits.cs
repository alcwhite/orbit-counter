using System;
using System.Collections.Generic;

namespace orbit_counter
{
    public static class Orbits
    {
        public static int OrbitCount(List<string> map)
        {
            int links = 0;
            var parsedMap = new Dictionary<string, string>();
            map.ForEach(orbit => {
                var splitOrbit = orbit.Split(')');
                parsedMap.Add(splitOrbit[1], splitOrbit[0]);
            });
            foreach (KeyValuePair<string, string> entry in parsedMap) 
            {
                int keyLinks = 1;
                string value = entry.Value;
                while (value != "COM")
                {
                    keyLinks++;
                    parsedMap.TryGetValue(entry.Value, out string newValue);
                    value = newValue;
                }
                links += keyLinks;
            }
            return links;
        }
    }
}