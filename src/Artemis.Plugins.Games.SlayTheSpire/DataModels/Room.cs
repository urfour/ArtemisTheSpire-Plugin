using System.Collections.Generic;

namespace Artemis.Plugins.Games.SlayTheSpire.DataModels
{
    public class Room
    {
        public class Coordinates
        {
            public int X { get; set; }
            public int Y { get; set; }
            public Coordinates() { }
        }
        public string? Symbol { get; set; }
        public Coordinates[]? Children { get; set; }
        public Room() {}
    }
}