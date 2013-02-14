using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LP.Domain.Tests
{
    [TestClass]
    public class ProjectServiceTests
    {
        [TestMethod]
        public void CreateProject()
        {
            ProjectService service = new ProjectService();
            service.CreateProject("Test name", "Test summary", "Test details");
        }
    }
}
