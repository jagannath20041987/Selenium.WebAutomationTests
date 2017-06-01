﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApp.Test.Framework;
using WebSite.Biz;

namespace WebApp.Tests
{    

    [TestClass]
    public class WebSiteTests
    {
        private HomePage _homePage;

        public WebSiteTests()
        {
            _homePage = new HomePage();
        }

        [TestMethod]
        public void Can_Goto_HomePage()
        {
            _homePage.GoTo();            
            Assert.IsTrue(_homePage.IsAt());
        }


        [TestMethod]
        public void Can_Select()
        {
            _homePage.GoTo();
            _homePage.Select();
        }

        [TestMethod]
        public void Can_UploadFile()
        {
            _homePage.GoTo();

            string filePath = @"C:\temp\test.txt";
            _homePage.Uploadfile(filePath);
        }
    }
}
