namespace Rosser.LaserCut.TileMaker.Models
{
    public class StyreneMaterial : Material
    {
        public StyreneMaterial(double thickness, Unit unit) : base(0.45, null, thickness, unit)
        {
        }

        public override string Name { get; } = "HIPS, PETG, Styrene";
    }
}