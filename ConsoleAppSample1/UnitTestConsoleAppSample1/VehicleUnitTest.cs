using ConsoleAppSample1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestConsoleAppSample1
{
    [TestClass]
    public class VehicleUnitTest
    {
        [TestMethod]
        public void VehicleCanDrive()
        {
            var v = new Vehicle();
            v.Drive();
            Assert.IsTrue(v.Log.Contains("Drove"));

            //v.BreakDown(); // NO parameter

            v.BreakDown("Broke");
            Assert.IsTrue(v.Log.Contains("Broke"));
        }

        [TestMethod]
        public void PlaneCanFly()
        {
            var v = new Plane();
            v.Drive();
            Assert.IsTrue(v.Log.Contains("Flew"));

            //v.BreakDown();    // No Parameter
            //v.BreakDown = () => v.Log += "We are just fine.";    // No parameter
            //v.Log = string.Empty;
            //v.BreakDown();
            //Assert.IsTrue(v.Log.Contains("Fell"));

            v.BreakDown("Engine Failure");
            Assert.IsTrue(v.Log.Contains("Fell"));


            v.BreakDown = x => v.Log += "We are just fine.";
            Assert.IsTrue(v.Log.Contains("Fell"));

        }

        [TestMethod]
        public void CrashesHurt()
        {
            var v = new Vehicle();
            v.Crash(x => x);
            Assert.IsTrue(v.Log.Contains("1"));

            v.Crash(x => x * 55);
            Assert.IsTrue(v.Log.Contains("55"));


        }

        [TestMethod]
        public void VehicleCanTransform()
        {
            var v = new Vehicle();
            Extensions.Transform(v);        // Outside object of Vehicle Class
            Assert.IsTrue(v.Log.Contains("AutoBot"));

            v.TransformVehicle();          // Make it part of the Vehicle Class
            Assert.IsTrue(v.Log.Contains("AutoBot"));

        }

        IEnumerable<int> numbers = Enumerable.Range(0, 100);

        [TestMethod]
        public void Linq101()
        {
            var numbers = new[] { 0, 1, 2, 3, 4, 5 };

            // withough Linq
            var actual = new List<int>();

            foreach (var number in numbers)
            {
                // List of ODD number into the list
                if (number % 2 == 0)
                    actual.Add(number);
            }

            Assert.AreEqual(3, actual.Count);

            Assert.AreEqual(3, numbers.Count(i => i % 2 == 0));
        }

        [TestMethod]
        public void LinqSelect()
        {
            var actual = numbers.Select(x => x * x);
            Assert.IsTrue(actual.Contains(9801));
            var actual12 = numbers.Where(x => x % 33 == 0).Select(x => x * x);
        }

        public void LinqComplex()
        {
            var Processes = System.Diagnostics.Process.GetProcesses();
            var name = Processes.Select(x => new { x.ProcessName, ThreadCount = x.Threads.Count })
                .Where(x => x.ThreadCount < 10);
            var otherstuff = from x in Processes
                             // where x.Modules.OfType<System.Diagnostics.ProcessModule>().Any(y=>y.ModuleMemorySize > 1000)
                             where x.Modules.Count > 5
                             orderby x.ProcessName
                             select new { x.ProcessName, x.PeakWorkingSet64, x.Responding };
        }
    }
}




















































































































































































































































































































































































        


 