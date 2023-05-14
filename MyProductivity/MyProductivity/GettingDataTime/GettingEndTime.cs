using MyProductivity.ApplicationCategories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyProductivity.GettingData
{
    internal class GettingEndTime : GettingTime
    {
        private Category _category;
        private List<string> _processNames;

        public GettingEndTime(Category category)
        {
            this._category = category;
            this._processNames = base.GettingProcessNames();
        }

        public override DateTime ProcessSearch()
        {
            var numberMatches = _category.applications.Intersect(_processNames).ToArray();

            if (numberMatches.Length < 1)
            {
                _category.EndTime = DateTime.Now;
            }
            return _category.EndTime;
        }
    }
}
