namespace Rosser.LaserCut.TileMaker.Models
{
    public class PaperMaterial : Material
    {
        public PaperMaterial(double thickness, Unit unit) : base(0.08, null, thickness, unit)
        {
        }

        public override string Name { get; } = "Paper";
    }
}