using NUnit.Framework;

namespace temp4.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

       
        [Test]
        public void Should_fill_the_board_with_single_character_gap()
        {

            string[] initialBoard = new[] { "...", ". .", "..." };
            string[] expectedBoard = new[] { "...", ".W.", "..." };

            var dojo = new Dojo(initialBoard);

            var result = dojo.Fill(1, 1, 'W');

            Assert.AreEqual(expectedBoard, result);
        }

        [Test]
        public void Should_fill_the_board_with_double_character_gap()
        {

            string[] initialBoard = new[] { "....", ".  .", "...." };
            string[] expectedBoard = new[] { "....", ".WW.", "...." };

            var dojo = new Dojo(initialBoard);

            var result = dojo.Fill(1, 1, 'W');

            Assert.AreEqual(expectedBoard, result);
        }



    }
}