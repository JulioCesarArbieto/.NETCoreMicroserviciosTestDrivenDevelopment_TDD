using CONTINER.API.MANAGER.Account.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Linq;
using CONTINER.API.MANAGER.Account.Controllers;
using System.Net;

namespace CONTINER.MANAGER.TestMicroservices.Account
{
    [TestClass]
    public class AccountControllerTests
    {
        private Mock<IServiceAccount> _servicesMock;
        [TestInitialize]
        public void OnInit()
        {
            _servicesMock = new Mock<IServiceAccount>();
        }

        [TestMethod]
        public void TestGet_All_Account()
        {
            var Accounts = new List<API.MANAGER.Account.Model.Account>();

            _servicesMock.Setup(o => o.GetAll()).Returns(Accounts);
            var controllerServices = new AccountController(_servicesMock.Object);
            controllerServices.Get();

            _servicesMock.Verify(x => x.GetAll());

            ////Act
            //var response = controllerServices.Accepted();
            ////Assert
            //Assert.AreEqual(response.StatusCode, HttpStatusCode.OK);
            //Assert.IsNotNull(response.Value);

            //var result = response.Content.ReadAsAsync<OutJsonModel>();

            //Assert.IsNotNull(result);
            //Assert.AreEqual(result.Code, Constantes.ServiceResponse.Code.SUCCESS);

            //var clientesActual = JsonConvert.DeserializeObject<List<Cliente>>(result.Data.ToString());

            //Assert.IsNotNull(clientesActual);
            //Assert.AreEqual(clientes.Count, clientesActual.Count);

        }

    }
}
