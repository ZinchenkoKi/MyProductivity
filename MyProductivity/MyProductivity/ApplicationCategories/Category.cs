using System;
using System.Collections.Generic;

namespace MyProductivity.ApplicationCategories
{
    public class Category
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public List<string> applications;

        public Category()
        {
            applications = new List<string> { };
        }
    }
}
