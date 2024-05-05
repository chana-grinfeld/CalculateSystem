//using System;
//using System.Collections.Generic;
//using System.IdentityModel.Tokens.Jwt;
//using System.Security.Claims;
//using System.Text;
//using DAL.Models;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Extensions.Configuration;
//using Microsoft.IdentityModel.Tokens;
//using Tweetinvi.Controllers.Auth;
//using Xunit;

//namespace EventsSystem.Tests
//{
//    public class LoginTest
//    {
//        private Mock<IAuthQueryExecutor> _mockAuthQueryExecutor;

//        public LoginTest()
//        {
//            _mockAuthQueryExecutor = new Mock<IAuthQueryExecutor>();
//            //_mockAuthQueryExecutor.Setup(x => x.GetValue<string>("Admin")).Returns("admin");
//        }

//        [Fact]
//        public void Test_Login_Success()
//        {
//            // Arrange
//            var controller = new AuthController(_mockAuthQueryExecutor.Object);
//            var request = new LoginModel { UserName = "Admin", Password = "123456" };
//            var token = AuthController.Login();

//            //    // Act
//            //    var result = controller.LoginAction(request) as ObjectResult;

//            //    // Assert
//            //    Assert.NotNull(result);
//            //    Assert.Equal(200, result.StatusCode);

//            //    var token = result.Value as dynamic;
//            //    Assert.NotNull(token);
//            //    Assert.NotEmpty(token.Token);
//            //}

//            //[Fact]
//            //public void Test_Login_Unauthorized()
//            //{
//            //    // Arrange
//            //    var controller = new AuthController(_mockAuthQueryExecutor.Object);
//            //    var request = new LoginModel { UserName = "User", Password = "12345" };

//            //    // Act
//            //    var result = controller.LoginAction(request) as UnauthorizedResult;

//            //    // Assert
//            //    Assert.NotNull(result);
//        }
//    }
//}