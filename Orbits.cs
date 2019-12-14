using System;
using System.Text;
using System.Collections.Generic;
using System.IO;

namespace orbit_counter
{
    public static class Orbits
    {
        public static Dictionary<string, string> OrbitDictionary(string mapFile)
        {
            string map = File.ReadAllText(mapFile, Encoding.UTF8);
            var parsedMap = new Dictionary<string, string>();
            var splitMap = map.Split(Environment.NewLine);
            foreach (string orbit in splitMap)
            {
                var splitOrbit = orbit.Split(')', 2);
                if (splitOrbit.Length == 2)
                    parsedMap.Add(splitOrbit[1], splitOrbit[0]);
            };
            return parsedMap;
        }
        public static int OrbitCount(string mapFile)
        {
            int links = 0;
            var parsedMap = OrbitDictionary(mapFile);
            foreach (KeyValuePair<string, string> entry in parsedMap) 
            {
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

        public static int YouToSantaCount(string mapFile)
        {
            int links = 0;
            var parsedMap = OrbitDictionary(mapFile);
            var youMap = new List<string>();
            var santaMap = new List<string>();
            string youValue = "YOU";
            string santaValue = "SAN";
            foreach (KeyValuePair<string, string> entry in parsedMap)
            {
                while (youValue != "COM")
                {
                    youMap.Add(youValue);
                    parsedMap.TryGetValue(youValue, out string newValue);
                    youValue = newValue;
                }
                while (santaValue != "COM" && !youMap.Contains(santaValue))
                {
                    santaMap.Add(santaValue);
                    parsedMap.TryGetValue(santaValue, out string newValue);
                    santaValue = newValue;
                }
            }
            links = santaMap.Count - 1 + youMap.IndexOf(santaValue) - 1; 

            return links;
        }
    }
}