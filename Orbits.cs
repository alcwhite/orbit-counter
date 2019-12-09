using System;
using System.Collections.Generic;

namespace orbit_counter
{
    public static class Orbits
    {
        public static int OrbitCount(string map)
        {
            int links = 0;
            var parsedMap = new Dictionary<string, string>();
            var splitMap = map.Split("\n");
            foreach (string orbit in splitMap)
            {
                var splitOrbit = orbit.Split(')', 2);
                parsedMap.Add(splitOrbit[1], splitOrbit[0]);
            };
            foreach (KeyValuePair<string, string> entry in parsedMap) 
            {
                Console.WriteLine(entry);
                int keyLinks = 1;
                string value = entry.Value;
                bool doAgain = true;
                while (value != "COM" && doAgain)
                {
                    keyLinks++;
                    doAgain = parsedMap.TryGetValue(value, out string newValue);
                    value = newValue;
                }
                links += keyLinks;
            }
            return links;
        }
    }
}