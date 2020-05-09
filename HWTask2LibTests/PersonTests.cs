using Microsoft.VisualStudio.TestTools.UnitTesting;
using HWTask2Lib;
using System;
using System.Collections.Generic;
using System.Text;


namespace HWTask2Lib.Tests
{
    [TestClass()]
    public class PersonTests
    {
        [TestMethod()]
        public void CheekName_name_nameRetyrned()
        {
            // Arrange
            string x = "name";
            string expected = "name";

            // Action
            Person p = new Person();
            p.Name = x;
            string actual = p.Name;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CheekName_null_ArgumentNullExceptionRetyrned()
        {
            Person p = new Person();
            p.Name = null;
        }

        [TestMethod()]
        public void CheekCity_city_cityRetyrned()
        {
            // Arrange
            string x = "city";
            string expected = "city";

            // Action
            Person p = new Person();
            p.Сity = x;
            string actual = p.Сity;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CheekCity_null_ArgumentNullExeptionRetyrned()
        {
            Person p = new Person();
            p.Сity = null;
        }

        [TestMethod()]
        public void CheckPhoneNumber_123456789_123456789Returned()
        {
            // Arrange
            int x = 123456789;
            int expected = 123456789;

            // Action
            var p = new Person();
            p.Phone_number = x;
            int actual = p.Phone_number;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CheckPhoneNumber_12345_FalseReturned()
        {
            // Arrange
            int x = 12345;
            bool expected = false;

            // Action
            var p = new Person();
            p.Phone_number = x;
            bool actual = p.CheckPhoneNumber();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CheckPhoneNumber_123456789_TrueReturned()
        {
            // Arrange
            int x = 123456789;
            bool expected = true;

            // Action
            var p = new Person();
            p.Phone_number = x;
            bool actual = p.CheckPhoneNumber();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CheckEmail_Satorimailer_FalseReturned()
        {
            // Arrange
            string x = "Satorimail.com";
            bool expected = false;

            // Action
            var p = new Person();
            p.Email = x;
            bool actual = p.CheckEmail();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CheckEmail_ContainDogChar_TrueReturned()
        {
            // Arrange
            string x = "Satori@mail.com";
            bool expected = true;

            // Action
            var p = new Person();
            p.Email = x;
            bool actual = p.CheckEmail();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}