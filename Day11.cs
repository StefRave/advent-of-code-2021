namespace AdventOfCode2021;

public class Day11
{
    private readonly ITestOutputHelper output;

    public Day11(ITestOutputHelper output)
    {
        this.output = output;
    }

    [Fact]
    public void Run()
    {
        var input = Advent.ReadInputLines()
            .Select(c => int.Parse(c))
            .ToArray();

        Advent.AssertAnswer1("answer1");

        Advent.AssertAnswer2(2);
    }
}
