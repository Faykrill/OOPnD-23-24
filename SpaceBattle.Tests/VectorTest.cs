namespace SpaceBattle.Lib.Tests;

public class VectorTests
{
    [Fact]
    public void Vector_GetHashCode()
    {
        var arr = new int[] { 1, 5 };
        var test = new Vector(arr);
        Assert.Equal(arr.GetHashCode(), test.GetHashCode());
    }

    [Fact]
    public void Vector_PassNullInCtor()
    {
        var arr = new int[] { 6, 1 };
        var test = new Vector(arr);
        Assert.True(!test.Equals(null));
    }

    [Fact]
    public void Vector_Equality()
    {
        var arr = new int[] { 4, 6 };
        var test1 = new Vector(arr);
        var test2 = new Vector(arr);
        Assert.True(test1 == test2);
    }

    [Fact]
    public void Vector_Inequality()
    {
        var test1 = new Vector(new int[] { 1, 2 });
        var test2 = new Vector(new int[] { 1, 2 });
        Assert.True(test1 != test2);
    }

    [Fact]
    public void Vector_Equals_PassNotVectorType()
    {
        var num = 2;
        var test = new Vector(new int[] { 1, 2 });
        Assert.True(!test.Equals(num));
    }
}
