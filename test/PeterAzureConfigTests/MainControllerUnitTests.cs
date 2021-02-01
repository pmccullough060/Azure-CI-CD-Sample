using Microsoft.AspNetCore.Mvc;
using PeterAzureConfig.Controllers;
using System;
using Xunit;

namespace PeterAzureConfigTests
{
    public class MainControllerUnitTests
    {
        [Fact]
        public void Get_StringProvided_StatusOkStringInContent()
        {
            //Arrange 
            MainController main = new MainController();

            //Act
            IActionResult result = main.Get("test");

            //Assert
            OkObjectResult okResult = (OkObjectResult)result;
            Assert.NotNull(okResult);
            Assert.Equal(200, okResult.StatusCode);
            Assert.Equal("test", (string)okResult.Value);
        }
    }
}
