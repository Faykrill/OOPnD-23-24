namespace SpaceBattle.Lib;

public class Vector
{
    private int[] coordinates;
    private int coord_cont;
    public Vector (params int[] coordinates){
        this.coordinates = coordinates;
        coord_cont = coordinates.Length;
    }
    public static Vector operator +(Vector a, Vector b){
        Vector c = new(new int[a.coord_cont]);
        c.coordinates = (a.coordinates.Select ((x, index) => x + b.coordinates[index]).ToArray());
        return c;
    }
    public override bool Equals(object? obj)
    {
        var otherVector = obj as Vector;
        return otherVector!._values.SequenceEqual(_values);
    }
    

    public override int GetHashCode()
    {
        return coordinates.GetHashCode();
    }
}
