using System;
using System.Collections.Generic;
using XF4.Template.ViewModels.Main;
using XF4.Template.Views;

namespace XF4.Template
{
    public static class Constants
    {
        public static class Navigation
        {
            public static IDictionary<Type, Type> RoutingTable = new Dictionary<Type, Type>
            {
                { typeof(MainPageViewModel), typeof(MainPage) },
            };

            public static Type[] Tabs = new[]
            {
                typeof(MainPage),
            };
        }
    }
}
