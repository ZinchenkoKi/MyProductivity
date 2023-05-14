using MyProductivity.ApplicationCategories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace MyProductivity.GettingData
{
    public class GettingTime
    {
        private Category _category;
        private List<string> _processNames = new List<string>();

        public GettingTime()
        {
            this._processNames = new List<string>();
        }

        public GettingTime(Category category)
        {
            this._category = category;
            this._processNames = GettingProcessNames();
        }

        public List<string> GettingProcessNames()
        {
            foreach (Process process in Process.GetProcesses())
            {
                _processNames.Add(process.ProcessName);
            }
            return _processNames.Distinct().ToList();
        }

        public virtual DateTime ProcessSearch()
        {
            var numberMatches = _category.applications.Intersect(_processNames).ToArray();

            if (numberMatches.Length > 0)
            {
                _category.StartTime = DateTime.Now;
            }
            return _category.StartTime;
        }
    }
}
