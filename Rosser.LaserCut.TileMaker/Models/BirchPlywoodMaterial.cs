namespace Rosser.LaserCut.TileMaker.Models
{
    public class BirchPlywoodMaterial : Material
    {
        public BirchPlywoodMaterial(double thickness, Unit unit)
            : base(0.4, new[]
            {
                (0.8, 0.08),
                (1.5, 0.16),
                (3.0, 0.2),
                (6.0, 0.22),
                (12.0, 0.3)
            }, thickness, unit)
        {
        }

        public override string Name { get; } = "Birch Plywood";
    }
}