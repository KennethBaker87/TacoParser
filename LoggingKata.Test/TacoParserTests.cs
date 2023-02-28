using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            // TODO: Complete Something, if anything

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        [InlineData("34.280205,-86.217115,Taco Bell Albertvill...", -86.217115)]
        [InlineData("33.556383,-86.889051,Taco Bell Birmingha...", -86.889051)]
        [InlineData("34.764965,-86.48607,Taco Bell Huntsvill...", -86.48607)]
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange
            var tacoParserInstance = new TacoParser();
            //Act
            var actual = tacoParserInstance.Parse(line);
            //Assert
            Assert.Equal(expected, actual.Location.Longitude);
        }


        //TODO: Create a test ShouldParseLatitude
        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        [InlineData("34.280205,-86.217115,Taco Bell Albertvill...", 34.280205)]
        [InlineData("33.556383,-86.889051,Taco Bell Birmingha...", 33.556383)]
        [InlineData("34.764965,-86.48607,Taco Bell Huntsvill...", 34.764965)]
        public void ShouldParseLatitude(string line, double expected)
        {
            //Arrange
            var tacoParserInstance = new TacoParser();
            //Act
            var actual = tacoParserInstance.Parse(line);
            //Assert
            Assert.Equal(expected, actual.Location.Latitude);
        }

    }
}
