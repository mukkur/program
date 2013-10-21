using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicContactsTests
{
    [TestClass]
    public class TodoVMTest
    {
        [TestMethod]
        public void AddTodoReallyAddsAnItem()
        {
            var vm = new BasicContacts.TodoVM();
            Assert.AreEqual(0, vm.List.Count);
            vm.Text = "Test";



        }
    }
}
