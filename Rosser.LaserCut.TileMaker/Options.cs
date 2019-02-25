namespace Rosser.LaserCut.TileMaker
{
    using System.Collections.Generic;
    using Models;

    public class Options
    {
        public bool               Hairline    { get; set; }
        public MaterialType       Material    { get; set; }
        public string             Shape       { get; set; }
        public IReadOnlyList<int> TabbedSides { get; set; }
        public double             TabWidth    { get; set; }
        public double             Thickness   { get; set; }
        public Unit               Units       { get; set; }
    }
}