namespace Rosser.LaserCut.TileMaker.Models
{
    public class MdfMaterial : Material
    {
        public MdfMaterial(double thickness, Unit unit)
            : base(0.4, new[]
            {
                (3.0, 0.16),
                (6.0, 0.2),
                (12.0, 0.28)
            }, thickness, unit)
        {
        }

        public override string Name { get; } = "MDF";
    }
}