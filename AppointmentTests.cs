using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Rashidova;
using System;

namespace Project_Rashidova_Tests
{
    [TestClass]
    public class AppointmentTests
    {
        private Appointment _appointment;

        [TestInitialize]
        public void Setup()
        {
           _appointment = new Appointment(DateTime.Now.AddDays(1));
        }

        [TestMethod]
        public void Book_FutureDate()
        {
            Assert.IsTrue(_appointment.Book(DateTime.Now.AddDays(2)));
        }

        [TestMethod]
        public void Book_PastDate()
        {
            Assert.IsFalse(_appointment.Book(DateTime.Now.AddDays(-1)));
        }
    }
}

