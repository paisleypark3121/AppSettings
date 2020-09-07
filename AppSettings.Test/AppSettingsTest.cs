using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppSettings.Test
{
    [TestClass]
    public class AppSettingsTest
    {
        [TestMethod]
        public void TestLocalAppSettings()
        {
            #region arrange
            IAppSettings appSettings=new AppSettings();
            string expected = "value_test";
            #endregion

            #region act
            string actual = appSettings["test"];
            #endregion

            #region assert
            Assert.AreEqual(expected, actual);
            #endregion
        }

        [TestMethod]
        public void TestLocalEnvironmentAppSettings()
        {
            #region arrange
            IAppSettings appSettings = new EnvironmentAppSettings();
            string expected = "value_test";
            #endregion

            #region act
            string actual = appSettings["test"];
            #endregion

            #region assert
            Assert.AreEqual(expected, actual);
            #endregion
        }
    }
}
