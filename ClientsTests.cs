using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Project_Rashidova;
using System.Text.RegularExpressions;

namespace Project_Rashidova_Tests
{
    [TestClass]
    public class ClientsTests
    {
        private Clients clients;

        [TestInitialize]
        public void Init()
        {
            clients = new Clients(
                "test@mail.com",
                "Улькер",
                "Рашидова",
                new DateTime(2005, 8, 21),
                "+38(050)-1234567"
            );
        }

        [TestMethod]
        public void Email_Symbol()
        {
            Assert.IsTrue(clients.Email.Contains("@"));
        }

        [TestMethod]
        public void ValidClient()
        {
            Assert.IsTrue(clients.IsValid());
        }

        [TestMethod]
        public void Login_ValidEmail()
        {
            Assert.IsTrue(clients.Login("test@mail.com", "пароль"));
        }

        [TestMethod]
        public void HasAppointment_Id()
        {
            Assert.IsTrue(clients.HasAppointment(5));
        }
    }
}
