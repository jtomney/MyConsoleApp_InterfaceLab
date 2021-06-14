using MyConsoleApp.Interfaces;
using MyConsoleApp.UniqueFilenameClass;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MyConsoleAppUnitTests
{
    public class CommandLineArgsParserUnitTest
    {
        /// <summary>
        /// Given:  A command line string array containing one item with a valid Server Name and AppID separated by a comma.
        /// When: The plugin parses that array.
        /// Then:  A single struct is returned whose Server Name property and Appid property are assigned their value from the array item.
        /// </summary>
        [Fact]
        public void ShouldParseCmdLineArgsToDto()
        {
            //Arrange
            string[] input = { "S3B4E02,JT2" };
            ServerNameAppIdDto expected = new ServerNameAppIdDto()
                                            { Servername = "S3B4E02", AppId = "JT2"};
            ICommandLineArgsParser sut = new CommandLineArgsParser();

            //Act
            var result = sut.ParseCmdLineArgsToSrvNmAppIdDTOs(input);

            //Assert
            Assert.Equal(expected.Servername, result[0].Servername);
            Assert.Equal(expected.AppId, result[0].AppId);
        }

        /// <summary>
        /// Given: A command line string array containing multiple items with a 
        ///        valid Server Name and AppID separated by a comma
        /// When: The plugin parses that array
        /// Then: structs are returned whose Server Name property and Appid property 
        ///       are assigned their value from the array. 
        /// </summary>
        [Fact]
        public void ShouldParseMultipleCmdLineArgsToDto()
        {
            //Arrange
            string[] input = { "S3B4E02,JT2", "S4B5E03,KC3", "S4B6E04,SD4" };
            List<ServerNameAppIdDto> expected = new List<ServerNameAppIdDto>()
                        { new ServerNameAppIdDto() { Servername = "S3B4E02", AppId = "JT2" },
                         new ServerNameAppIdDto() { Servername = "S4B5E03", AppId = "KC3" },
                         new ServerNameAppIdDto() { Servername = "S4B6E04", AppId = "SD4" }};
            ICommandLineArgsParser sut = new CommandLineArgsParser();

            //Act
            var result = sut.ParseCmdLineArgsToSrvNmAppIdDTOs(input);

            //Assert
            Assert.Equal(expected[0].Servername, result[0].Servername);
            Assert.Equal(expected[0].AppId, result[0].AppId);

            Assert.Equal(expected[1].Servername, result[1].Servername);
            Assert.Equal(expected[1].AppId, result[1].AppId);

            Assert.Equal(expected[2].Servername, result[2].Servername);
            Assert.Equal(expected[2].AppId, result[2].AppId);
        }
    }
}
