using System;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace AdventOfCode2021
{
    public class Day19
    {
        private readonly ITestOutputHelper output;

        public Day19(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void Run()
        {
            var input1 = Advent.ReadInputLines()
                .Select(c => int.Parse(c))
                .ToArray();

            Advent.AssertAnswer1("answer1");

            Advent.AssertAnswer2(2);
        }
    }
}