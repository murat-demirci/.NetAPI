using JwtMiddlevare.API;
using JwtMiddlevare.API.Controllers;
using JwtMiddlevare.API.Data;
using JwtMiddlevare.API.Models;
using JwtMiddlevare.API.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Moq;

namespace TestProject2
{
    public class UnitTest1
    {
        private ITokenUtil tokenUtil;
        private ITokenUtil tokenUtilNull;
        private Mock<ITokenUtil> tokenUtilMock;
        private Mock<IOptions<JwtSettings>> options;
        private IOptions<JwtSettings> _options = Options.Create(new JwtSettings()
        {
            Key = "muratdemircimuratdemircimuratdemircimuratdemircimuratdemircimuratdemircimuratdemircimuratdemirci",
            Issuer = "jwtTokenSample",
            Audience = "jwtTokenSample"
        });
        private IOptions<JwtSettings> _optionsnull = Options.Create(new JwtSettings()
        {
            Key = null,
            Issuer = "jwtTokenSample",
            Audience = "jwtTokenSample"
        });
        public UnitTest1()
        {
            tokenUtilMock = new Mock<ITokenUtil>();
            tokenUtil = new TokenUtil(_options);
            tokenUtilNull = new TokenUtil(_optionsnull);
        }
        [Fact]
        public async void Login_Succeeded()
        {
            await LoadData.Load();
            var authController = new AuthController(tokenUtilMock.Object);

            var user = new UserDataModel { Email = "john@mail.com", Password = "123456" };
            var response = await authController.Login(user);

            Assert.NotNull(response);
            Assert.IsType<OkObjectResult>(response);
        }

        [Fact]
        public async void Login_Failed_Wrong_Password()
        {
            var authController = new AuthController(tokenUtilMock.Object);

            var user = new UserDataModel { Email = "murat@mail.com", Password = "12345" };
            var response = await authController.Login(user);

            Assert.NotNull(response);
            Assert.IsType<ObjectResult>(response);
        }

        [Fact]
        public async void Login_Failed_Wrong_Email()
        {
            var authController = new AuthController(tokenUtilMock.Object);

            var user = new UserDataModel { Email = "muratt@mail.com", Password = "123456" };
            var response = await authController.Login(user);
            Assert.NotNull(response);
            Assert.IsType<ObjectResult>(response);
        }

        [Fact]
        public async void Generate_Token_Succeeded()
        {
            var user = new UserModel
            {
                Email = "murat@mail.com",
                Password = "123456",
                Id = 1,
                Name = "murat",
                Role = "admin"
            };

            var response = await tokenUtil.GenerateToken(user);
            Assert.NotNull(response);
            Assert.IsType<Tokenresponse>(response);
        }

        [Fact]
        public async void Generate_Token_Key_Null()
        {
            var user = new UserModel
            {
                Email = "murat@mail.com",
                Password = "123456",
                Id = 1,
                Name = "murat",
                Role = "admin"
            };

            var response = await tokenUtilNull.GenerateToken(user);
            Assert.Null(response);
        }

        [Fact]
        public async void WeatherForecast_Succeeded()
        {
            var authController = new AuthController(tokenUtilMock.Object);

            var user = new UserDataModel { Email = "john@mail.com", Password = "123456" };
            var response = await authController.Login(user);

            var weather = new WeatherForecastController();
            var data = weather.Get();
            Assert.IsType<WeatherForecast[]>(data);
        }
    }
}