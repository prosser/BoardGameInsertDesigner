namespace Rosser.LaserCut.TileMaker.Models
{
    using System.Collections.Generic;

    public class VeneeredMdfMaterial : Material
    {
        public VeneeredMdfMaterial(double thickness, Unit unit) : base(0.17, null, thickness, unit)
        {
        }

        public override string Name { get; } = "Veneered MDF";
    }
}