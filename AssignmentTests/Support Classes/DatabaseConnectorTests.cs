using Microsoft.VisualStudio.TestTools.UnitTesting;
using Software_Engineering_Assignment.Support_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineering_Assignment.Support_Classes.Tests
{
    [TestClass()]
    public class DatabaseConnectorTests
    {
        [TestMethod()]
        public void LogEventTest()
        {
            //Add four values to event log
            DatabaseConnector.Instance.LogEvent("Log event unit test", "Staff", 0);
            DatabaseConnector.Instance.LogEvent("Log event unit test", "Patient", 0);
            DatabaseConnector.Instance.LogEvent("Log event unit test", "Bedside", 0);
            DatabaseConnector.Instance.LogEvent("Log event unit test", "Module", 0);

            //Retrive event log from database
            //four values have manually been inserted into the event log database table
            //if log count has increased to 9 then test has passed
            var log = DatabaseConnector.Instance.GetEventLog();
            if (log.Count != 9) Assert.Fail();
            else Assert.IsTrue(true);
        }

        [TestMethod()]
        public void GetEventLogTest()
        {
            //Add four values to event log
            DatabaseConnector.Instance.LogEvent("Log event unit test", "Staff", 0);
            DatabaseConnector.Instance.LogEvent("Log event unit test", "Patient", 0);
            DatabaseConnector.Instance.LogEvent("Log event unit test", "Bedside", 0);
            DatabaseConnector.Instance.LogEvent("Log event unit test", "Module", 0);

            //Retrive event log from database
            //four values have manually been inserted into the event log database table
            //if log count has increased to 9 then test has passed
            var log = DatabaseConnector.Instance.GetEventLog();
            if (log.Count != 9) Assert.Fail();
            else Assert.IsTrue(true);
        }

        [TestMethod()]
        public void UpdateModuleTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void RegisterModuleTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetUnregisteredStaffTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetOnCallStaffTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetStaffTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAllStaffTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetPatientTest()
        {
            Assert.Fail();
        }
    }
}