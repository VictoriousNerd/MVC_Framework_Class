﻿using System.Web;
using System.Web.Mvc;

namespace ClassAssignments_Day2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
