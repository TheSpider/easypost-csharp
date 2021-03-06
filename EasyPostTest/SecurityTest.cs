﻿using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using EasyPost;

namespace EasyPostTest {
    [TestClass]
    public class SecurityTest {
        [TestMethod]
        public void TestGetProtocol() {
            Assert.AreEqual(Security.GetProtocol(), SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12);
        }
    }
}
