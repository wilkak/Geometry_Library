
using GeometryLibrary.Figures;

namespace GeometryLibrary.Extensions;

public static class TriangleExtensions
{
    public static bool IsRightAngled(this Triangle triangle)
    {
        double[] sides = { triangle.SideA, triangle.SideB, triangle.SideC };
        Array.Sort(sides);
        return Math.Abs(Math.Pow(sides[2], 2) - (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2))) < 1e-10;
    }
}