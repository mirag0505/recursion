namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void Task1()
    {
        Assert.Equal(1, Recursion.Task1.MyPow(1, 1));
        Assert.Equal(1, Recursion.Task1.MyPow(1, 0));
        Assert.Equal(1, Recursion.Task1.MyPow(3, 0));

        Assert.Equal(4, Recursion.Task1.MyPow(2, 2));
        Assert.Equal(8, Recursion.Task1.MyPow(2, 3));
        Assert.Equal(16, Recursion.Task1.MyPow(2, 4));


        Assert.Equal(9, Recursion.Task1.MyPow(3, 2));
        Assert.Equal(27, Recursion.Task1.MyPow(3, 3));
        Assert.Equal(81, Recursion.Task1.MyPow(3, 4));
    }

    [Fact]
    public void Task2()
    {
        Assert.Equal(1, Recursion.Task2.SumOfNumber(0, 1));
        Assert.Equal(2, Recursion.Task2.SumOfNumber(0, 11));
        Assert.Equal(3, Recursion.Task2.SumOfNumber(0, 111));

        Assert.Equal(4, Recursion.Task2.SumOfNumber(0, 22));
        Assert.Equal(6, Recursion.Task2.SumOfNumber(0, 222));

        Assert.Equal(6, Recursion.Task2.SumOfNumber(0, 123));
        Assert.Equal(0, Recursion.Task2.SumOfNumber(0, 000));
    }
}