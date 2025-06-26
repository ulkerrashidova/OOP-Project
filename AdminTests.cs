using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Rashidova;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Rashidova_Tests
{
    [TestClass]
    public class AdminTests
    {
        private Admin _admin;
        [TestInitialize]
        public void Setup()
        {
            _admin = new Admin("SystemAdministrator");
        }

        [TestMethod]
        public void Role_Assigned()
        {
            Assert.AreEqual("SystemAdministrator", _admin.Role);
        }

        [TestMethod]
        public void ManageUsers_HasUsers()
        {
            string[] users = new string[] { "user1", "user2" };
            Assert.IsTrue(_admin.ManageUsers(users));
        }

        [TestMethod]
        public void ManageUsers_NoUsers()
        {
            string[] users = new string[] { };
            Assert.IsFalse(_admin.ManageUsers(users));
        }

        [TestMethod]
        public void ManageUsers_NullUsers()
        {
            Assert.IsFalse(_admin.ManageUsers(null));
        }
    }
}
