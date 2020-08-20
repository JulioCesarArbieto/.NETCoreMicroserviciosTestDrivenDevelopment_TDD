using CONTINER.API.MANAGER.Cross.Jwt.Jwt;
using CONTINER.API.MANAGER.Security.Controllers;
using CONTINER.API.MANAGER.Security.Service;
using Microsoft.Extensions.Options;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;

namespace CONTINER.MANAGER.TestMicroservices.Security
{
    [TestClass]
    public class AuthControllerTest
    {
        private Mock<IServiceAccess> _servicesMock;
        private Mock<IOptionsSnapshot<JwtOptions>> _jwtOptionMock;
        [TestInitialize]
        public void OnInit()
        {
            _servicesMock = new Mock<IServiceAccess>();
            _jwtOptionMock = new Mock<IOptionsSnapshot<JwtOptions>>();
        }
        [TestMethod]
        public void TestGet_All_Access()
        {
            var Access = new List<API.MANAGER.Security.Model.Access>();

            _servicesMock.Setup(o => o.GetAll()).Returns(Access);
            var AuthController = new AuthController(_servicesMock.Object, _jwtOptionMock.Object);
            AuthController.Get();

            _servicesMock.Verify(x => x.GetAll());
        }
    }
}
