using AltkomSoftware.Onstage.Core.Services.Navigation;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF4.Template.Services.Navigation
{
    public interface INavigationService
    {
        Task InitializeAsync<TStartViewModel, TStartPage>(IDictionary<Type, Type> routingTable, IEnumerable<Type> appTabs = null)
            where TStartViewModel : IInitializable
            where TStartPage : Page;

        Task GoToModalAsync<TViewModel, TPage>(object parameter, bool animated = true)
            where TViewModel : IInitializable
            where TPage : Page;

        Task PopAsync(bool animated = true);

        Task PopToRootAsync(bool animated = true);

        Task PopModalAsync(bool animated = true);
    }
}
