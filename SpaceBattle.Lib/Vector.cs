namespace SpaceBattle.Lib;

public class Vector
{
    private int[] coordinates;
    private readonly int coord_cont;
    public Vector(params int[] coordinates)
    {
        this.coordinates = coordinates;
        coord_cont = coordinates.Length;
    }
    public static Vector operator +(Vector a, Vector b)
    {
        Vector c = new(new int[a.coord_cont]);
        c.coordinates = (a.coordinates.Select((x, index) => x + b.coordinates[index]).ToArray());
        return c;
    }
    public override bool Equals(object? obj)
    {
        if (obj == null)
        {
            return false;
        }

        return coordinates.SequenceEqual(((Vector)obj).coordinates);
    }

    public override int GetHashCode()
    {
        return coordinates.GetHashCode();
    }
}
