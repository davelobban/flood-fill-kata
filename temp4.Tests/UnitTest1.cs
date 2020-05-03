using NUnit.Framework;

namespace temp4.Tests
{
    public class Tests
    {
        [TestCase(0, 0, 'W', new[] { "." }, ExpectedResult = new[] { "W" })]
        [TestCase(0, 0, 'W', new[] { ".." }, ExpectedResult = new[] { "WW" })]
        [TestCase(0, 1, 'W', new[] { ".." }, ExpectedResult = new[] { "WW" })]
        [TestCase(0, 1, 'W', new[] { "..." }, ExpectedResult = new[] { "WWW" })]
        [TestCase(0, 1, 'W', new[] { "...." }, ExpectedResult = new[] { "WWWW" })]
        [TestCase(0, 0, 'W', new[] { ".#." }, ExpectedResult = new[] { "W#." })]
        [TestCase(0, 2, 'W', new[] { ".#..#" }, ExpectedResult = new[] { ".#WW#" })]
        [TestCase(0, 3, 'W', new[] { ".#..#" }, ExpectedResult = new[] { ".#WW#" })]
        public string[] Should_fill_empty_cells_in_row(int rowIndex, int colIndex, char filler, string[] board)
        {
            var dojo = new Dojo(board);

            return dojo.Fill(rowIndex, colIndex, filler);
        }


        [Test]
        public void Should_fill_empty_cells_in_two_rows()
        {
            var initialBoard = new[] { ".#..#",
                                       "....." };

            var expectedBoard = new[] { "W#WW#",
                                        "WWWWW" };

            var dojo = new Dojo(initialBoard);
            var result = dojo.Fill(0, 0, 'W');

            Assert.AreEqual(expectedBoard, result);
        }

        [Test]
        public void Should_fill_empty_cells_in_three_rows()
        {
            var initialBoard = new[] { ".#..#", 
                                       "...##",
                                       "..#.." };

            var expectedBoard = new[] { "W#WW#", 
                                        "WWW##", 
                                        "WW#.." };

            var dojo = new Dojo(initialBoard);
            var result = dojo.Fill(0, 0, 'W');

            Assert.AreEqual(expectedBoard, result);
        }

        [Test]
        public void Should_fill_empty_cells_in_multiple_rows()
        {
            var initialBoard = new[] { ".--------",
                                       ".........",
                                       "--------.",
                                       ".........",
                                       ".--------",
                                       "........-" };

            var expectedBoard = new[] { "W--------",
                                        "WWWWWWWWW",
                                        "--------W",
                                        "WWWWWWWWW",
                                        "W--------",
                                        "WWWWWWWW-" };

            var dojo = new Dojo(initialBoard);
            var result = dojo.Fill(3, 5, 'W');

            Assert.AreEqual(expectedBoard, result);
        }

        [Test]
        public void Should_fill_empty_cells_in_multiple_rows_respecting_barrier()
        {
            var initialBoard = new[] { ".--------",
                                       ".........",
                                       "---------",
                                       ".........",
                                       ".--------",
                                       "........-" };

            var expectedBoard = new[] { "W--------",
                                        "WWWWWWWWW",
                                        "---------",
                                       ".........",
                                       ".--------",
                                       "........-" };

            var dojo = new Dojo(initialBoard);
            var result = dojo.Fill(0, 0, 'W');

            Assert.AreEqual(expectedBoard, result);
        }
    }
}