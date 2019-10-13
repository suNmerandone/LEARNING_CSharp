using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LCConsoleApp.Tests
{
    [TestClass()]
    public class CodilitySolutionTests
    {
        [TestMethod()]
        public void solution_fileAndSizeClassficationTest()
        {
            // arrange
            var Solution = new CodilitySolution();
            var expected = "music 1011b\nimages 0b\nmovies 10200b\nother 105b";

            // act
            string S = "my.song.mp3 11b\ngreatSong.flac 1000b\nnot3.txt 5b\nvideo.mp4 200b\ngame.exe 100b\nmov!e.mkv 10000b";
            var actual = Solution.solution_fileAndSizeClassfication(S);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void solution_calTripAppealFomularTest()
        {
            // arrange
            var Solution = new CodilitySolution();
            var expected = 6;

            // act
            var actual = Solution.solution_calTripAppealFomular(3, 3, 1, 1);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void solution_highestAttractivenessCitiesTest_3CitiesReturn6()
        {
            // arrange
            var Solution = new CodilitySolution();
            var expected = 6;

            // act
            int[] A = { 1, 3, -3 };
            var actual = Solution.solution_highestAttractivenessCities(A);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void solution_highestAttractivenessCitiesTest_6CitiesReturn14()
        {
            // arrange
            var Solution = new CodilitySolution();
            var expected = 14;

            // act
            int[] A = { -8, 4, 0, 5, -3, 6 };
            var actual = Solution.solution_highestAttractivenessCities(A);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}