using System;

namespace Kino
{
    public class Cinema
    {
        public string Name { get; set; }
        public string Location { get; set; }

        public Cinema(string name, string location)
        {
            Name = name;
            Location = location;
        }

        public string Gdziekino()
        {
            return $"Kino: {Name}   Lokalizacja: {Location}";
        }
    }
}
