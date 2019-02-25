namespace Rosser.LaserCut.TileMaker.Models
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Text.RegularExpressions;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.CodeAnalysis.CSharp.Scripting;
    using Microsoft.CodeAnalysis.Scripting;
    using SkiaSharp;

    public class Polygon
    {
        private readonly IEnumerable<SKPoint> points;

        public Polygon(IEnumerable<SKPoint> points)
        {
            this.points = points;
        }

        public static async Task<Polygon> Parse(string text, object context, CancellationToken ct = default)
        {
            var replacements = new Dictionary<string, string>();
            foreach (Match match in Regex.Matches(text, @"({[^}]+})"))
            {
                string group = match.Groups[1].Value;

                if (replacements.ContainsKey(group)) continue;

                string expr = group.Substring(1, group.Length - 2);

                var evaluated = (double) await CSharpScript
                                              .EvaluateAsync(expr, ScriptOptions.Default, context, null, ct)
                                              .ConfigureAwait(false);

                replacements.Add(group, evaluated.ToString(CultureInfo.CurrentUICulture));
            }

            foreach (KeyValuePair<string, string> r in replacements)
            {
                text = text.Replace(r.Key, r.Value);
            }

            return new Polygon(ParsePoints(text));
        }

        private static IEnumerable<SKPoint> ParsePoints(string text)
        {
            foreach (string token in text.Split(' ', StringSplitOptions.RemoveEmptyEntries))
            {
                string[] xy = token.Split(',', 2);
                yield return new SKPoint(float.Parse(xy[0]), float.Parse(xy[1]));
            }
        }
    }
}