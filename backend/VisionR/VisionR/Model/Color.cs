using System.Collections.Generic;

namespace VisionR.Model
{
    public class Color:Entity
    {
        public string DominantColorForeground { get; set; }
        public string DominantColorBackground { get; set; }
        public string AccentColor { get; set; }
        public bool IsBwImg { get; set; }
    }
}