using MyConsoleApp.Interfaces;
using MyConsoleApp.UniqueFilenameClass;
using MyConsoleAppUnitTests.Fake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MyConsoleAppUnitTests
{
    public class DciFilenameGeneratorUnitTest
    {
        [Fact]
        public void ShouldGenerateFilenameThatStartsWithServerNameAppId()
        {
            //Arrange
            string inputServerName = "S3B4E02";
            string inputAppId = "JT2";
            string expectedStartWith = "S3B4E02JT2";
            ILogger logger = new FakeLogger();
            IDciFilenameGenerator sut = new DciFilenameGenerator(logger);

            //Act
            string result = sut.GenerateUniqueDciFilename(inputServerName, inputAppId);

            //Assert
            Assert.StartsWith(expectedStartWith, result);
        }
    }
}
