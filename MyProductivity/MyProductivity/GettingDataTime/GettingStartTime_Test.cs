using System;
using MyProductivity.ApplicationCategories;
using MyProductivity.GettingData;
using NUnit.Framework;

namespace MyProductivity.GettingDataTime
{
    partial class GettingStartTime_Test
    {
        [Test]
        public void AareRunningPrograms()
        {
            var programming = new Category();
            var startTime = new GettingStartTime(programming);

            programming.applications.Add("chrome");
            programming.StartTime = startTime.ProcessSearch();
            Assert.AreEqual(DateTime.Now.ToString("T"), programming.StartTime.ToString("T"));
        }

        [Test]
        public void NoProgramsRunning()
        {
            var programming = new Category();
            var startTime = new GettingStartTime(programming);

            programming.applications.Add("chrome");
            programming.StartTime = startTime.ProcessSearch();
            Assert.AreEqual("0:00:00", programming.StartTime.ToString("T"));
        }
    }
}
