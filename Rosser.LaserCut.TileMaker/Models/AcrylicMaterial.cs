namespace Rosser.LaserCut.TileMaker.Models
{
    public class AcrylicMaterial : Material
    {
        public AcrylicMaterial(double thickness, Unit unit)
            : base(0.4, new[]
            {
                (3.0, 0.18),
                (8.0, 0.21),
                (15.0, 0.3),
                (20.0, 0.32)
            }, thickness, unit)
        {
        }

        public override string Name { get; } = "Acrylic";

        public override bool NeedsStrainRelief => true;
    }
}