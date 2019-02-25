namespace Rosser.LaserCut.TileMaker.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Material
    {
        protected Material(
            double defaultKerf, IReadOnlyList<(double MaximumThickness, double KerfInMillimeters)> kerfs,
            double thickness,   Unit                                                               unit)
        {
            switch (unit)
            {
                case Unit.Millimeters:
                    this.Thickness = thickness;
                    break;
                case Unit.Inches:
                    this.Thickness = thickness * 25.4;
                    break;
                case Unit.Centimeters:
                    this.Thickness = thickness * 10;
                    break;

                case Unit.Microns:
                    this.Thickness = thickness * 1000;
                    break;

                default:
                    throw new NotSupportedException();
            }

            this.Kerf = kerfs == null
                ? defaultKerf
                : kerfs
                 .Where(x => x.MaximumThickness <= this.Thickness)
                 .Select(x => (double?) x.KerfInMillimeters)
                 .FirstOrDefault() ?? defaultKerf;
        }

        public double Kerf { get; }


        public abstract string Name { get; }

        public virtual bool NeedsStrainRelief => false;

        public double Thickness { get; }
    }
}