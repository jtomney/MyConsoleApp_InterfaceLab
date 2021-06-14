using MyConsoleApp.Interfaces;
using MyConsoleApp.UniqueFilenameClass;
using MyConsoleAppUnitTests.Fake;
using System;
using Xunit;

namespace MyConsoleAppUnitTests
{
    public class DciFileNameGeneratorUnitTest
    {
        /// <summary>
        /// Given: a valid Server Name and an AppID  as input
        /// When: the plugin completes its processing
        /// Then: the log file contains the file name that starts with the Server Name and AppID
        /// </summary>
        [Fact]
        public void ShouldCreateFileNameThatStartsWithServerNameAppId()
        {
            //Arrange
            string inputServerName = "S3B4E02";
            string inputAppID = "JT2";
            string expectedStartWith = "S3B4E02JT2";
            ILogger logger = new FakeLogger();
            IDciFilenameGenerator sut = new DciFilenameGenerator(logger);

            //Act
            string result = sut.GenerateUniqueDciFilename(inputServerName, inputAppID);

            //Assert
            Assert.StartsWith(expectedStartWith, result);            
        }

        /// <summary>
        /// Given:  Multiple Server Name & AppID pairs as input
        /// When:  The plugin completes processing
        /// Then:  There is a unique file name for each input
        /// </summary>
        /// <param name="inputServerName"></param>
        /// <param name="inputAppID"></param>
        /// <param name="expectedStartWith"></param>
        [Theory]
        [InlineData("S3B4E02", "JT2", "S3B4E02JT2")]
        [InlineData("S4B5E03", "KC3", "S4B5E03KC3")]
        [InlineData("S4B6E04", "SD4", "S4B6E04SD4")]
        public void ShouldCreateMultipleFileNameThatStartsWithServerNameAppId(string inputServerName,
                                    string inputAppID, string expectedStartWith)
        {
            //Arrange
            ILogger logger = new FakeLogger();
            IDciFilenameGenerator sut = new DciFilenameGenerator(logger);

            //Act
            var result = sut.GenerateUniqueDciFilename(inputServerName, inputAppID);

            //Assert
            Assert.StartsWith(expectedStartWith, result);
        }
    }
}
