using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AKQAProject;
using AKQAProject.Controllers;
using System.Net.Http;
using System.Web.Http;

namespace AKQAProject.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void CheckIsNotNull()
        {
            HomeApiController controller = new HomeApiController();
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();
            string result = controller.RetrunWords("XYZ", "123").StatusCode.ToString();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CheckValues()
        {
            HomeApiController controller = new HomeApiController();
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();
            HttpResponseMessage result = controller.RetrunWords("XYZ", "123");
            string strVal = result.Content.ReadAsStringAsync().Result;
           Assert.AreEqual(strVal, "\"One Hundred and TwentyThree  Cent\"");
        }

        
    }
}
