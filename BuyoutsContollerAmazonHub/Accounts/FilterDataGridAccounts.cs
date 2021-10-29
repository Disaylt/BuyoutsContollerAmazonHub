using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyoutsContollerAmazonHub.Accounts
{
    public static class FilterDataGridAccounts
    {
        public static string GetFilter(Dictionary<string, string> filters)
        {
            bool firstValueFilter = true;
            string filterString = string.Empty;
            foreach(var filter in filters)
            {
                if(FilterExists(filter.Value))
                {
                    if(firstValueFilter)
                    {
                        filterString = GetValueFilter(filter.Key, filter.Value);
                        firstValueFilter = false;
                    }
                    else
                    {
                        string valueFilter = GetValueFilter(filter.Key, filter.Value);
                        filterString += $" and {valueFilter}";
                    }
                }
            }
            return filterString;
        }

        private static bool FilterExists(string value)
        {
            if(value != string.Empty && value != "Все")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static string GetValueFilter(string key, string value)
        {
            string valueFilter;
            if (key == PlanningTableColumnsName.Session)
            {
                valueFilter = $"{key} like '%{value}%'";
            }
            else
            {
                bool boleanValue = value == "Активные";
                valueFilter = $"{key} = '{boleanValue}'";
            }
            return valueFilter;
        }
    }
}
