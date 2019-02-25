namespace Rosser.LaserCut.TileMaker.Models
{
    using System.ComponentModel;

    public enum MaterialType
    {
        [Description("Acrylic")]       Acrylic,
        [Description("Birch Plywood")] BirchPlywood,
        [Description("Greyboard")]     Greyboard,
        [Description("MDF")]           Mdf,
        [Description("Paper")]         Paper,
        [Description("Styrene")]       Styrene,
        [Description("Veneered MDF")]  VeneeredMdf
    }
}