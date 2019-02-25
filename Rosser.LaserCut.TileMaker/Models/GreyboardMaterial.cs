namespace Rosser.LaserCut.TileMaker.Models
{
    public class GreyboardMaterial : Material
    {
        public GreyboardMaterial(double thickness, Unit unit)
            : base(0.16, new[]
            {
                (1.2, 0.16),
                (2.4, 0.12)
            }, thickness, unit)
        {
        }

        public override string Name { get; } = "Greyboard";
    }
}