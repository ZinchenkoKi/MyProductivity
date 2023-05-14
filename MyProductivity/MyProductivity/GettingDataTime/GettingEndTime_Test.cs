using MyProductivity.ApplicationCategories;
using MyProductivity.GettingData;
using NUnit.Framework;
using System;

namespace MyProductivity.GettingDataTime
{
    public class GettingEndTime_Test
    {
        [Test]
        public void AareRunningPrograms() 
        {
            var programming = new Category();
            var endTime = new GettingEndTime(programming);

            programming.applications.Add("chrome");
            programming.EndTime = endTime.ProcessSearch();
            Assert.AreEqual("0:00:00", programming.EndTime.ToString("T"));
        }

        [Test]
        public void NoProgramsRunning()
        {
            var programming = new Category();
            var endTime = new GettingEndTime(programming);

            programming.applications.Add("chrome");
            programming.EndTime = endTime.ProcessSearch();
            Assert.AreEqual(DateTime.Now.ToString("T"), programming.EndTime.ToString("T"));
        }
    }
}
