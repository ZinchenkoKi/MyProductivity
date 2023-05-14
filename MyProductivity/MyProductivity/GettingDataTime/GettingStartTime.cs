using System;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;
using MyProductivity.ApplicationCategories;

namespace MyProductivity.GettingData
{
    public class GettingStartTime : GettingTime
    {
        private Category _category;
        private List<string> _processNames;

        public GettingStartTime(Category category)
        {
            this._category = category;
            this._processNames = base.GettingProcessNames();
        }

        public override DateTime ProcessSearch()
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
