using CONTINER.API.MANAGER.Cross.RabbitMQ.RabbitMQ.Bus;
using CONTINER.API.MANAGER.Deposit.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CONTINER.MANAGER.TestMicroservices.Deposit
{
    [TestClass]
    public class TransactionControllerTest
    {
        private Mock<IServiceTransaction> _servicesTransactionMock;
        private Mock<IServiceAccount> _serviceAccountMock;
        private Mock<IEventBus> _busMock;
        [TestInitialize]
        public void OnInit()
        {
            _servicesTransactionMock = new Mock<IServiceTransaction>();
            _serviceAccountMock = new Mock<IServiceAccount>();
            _busMock = new Mock<IEventBus>();
        }

        [TestMethod]
        public void TestGet_All_Account()
        {
            //var Accounts = new IActionResult();
            //var TransactionRequest = new TransactionRequest()
            //{
            //    AccountId = 0,
            //    Amount = 100
            //};

            //_servicesTransactionMock.Setup(o => o.Deposit(TransactionRequest)).Returns(Accounts);
            //var controllerServices = new AccountController(_servicesMock.Object);
            //controllerServices.Get();

            //_servicesMock.Verify(x => x.GetAll());
        }
    }
}
