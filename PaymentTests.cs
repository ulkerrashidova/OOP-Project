using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Rashidova;

namespace Project_Rashidova_Tests
{
    [TestClass]
    public class PaymentTests
    {
        private Payment _payment;

        [TestInitialize]
        public void Setup()
        {
            _payment = new Payment(100m, true);
        }

        [TestMethod]
        public void Amount_Valid()
        {
            Assert.IsTrue(_payment.IsAmountValid());
        }

        [TestMethod]
        public void Amount_Invalid()
        {
            var invalidPayment = new Payment(0m, false);
            Assert.IsFalse(invalidPayment.IsAmountValid());
        }
    }
}


