using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using XF4.Template.Services.Navigation;

namespace AltkomSoftware.Onstage.Core.Services.Navigation
{
    public interface IShellNavigationService : INavigationService
    {
        Task GoToAsync(ShellNavigationState route, bool animated = true);
    }

    public class ShellNavigationService : IShellNavigationService
    {
        #region PROPS
        private IDictionary<Type, Type> _routingTable;
        private IEnumerable<Type> _appTabs;

        public Page MainPage { get; set; }
        #endregion

        public ShellNavigationService() { }

        /// <typeparam name="TStartViewModel">On app start, this will be the first viewModel to be navigated to.</typeparam>
        /// <param name="routingTable">A dictionary connecting pages to their viewModels</param>
        /// <param name="appTabs">App's main tabs</param>
        public async Task InitializeAsync<TStartViewModel, TStartPage>(IDictionary<Type, Type> routingTable, IEnumerable<Type> appTabs = null)
            where TStartViewModel : IInitializable
            where TStartPage : Page
        {
            _routingTable = routingTable ?? throw new ArgumentNullException(nameof(routingTable));
            _appTabs = appTabs ?? Enumerable.Empty<Type>();

            if (!_appTabs.Any(t => typeof(TStartViewModel) == t))
                await Task.CompletedTask;

            Application.Current.MainPage = MainPage = Shell.Current;
        }

        #region NAVIGATION
        public async Task GoToAsync(ShellNavigationState route, bool animated = true)
        {
            // TODO: Page caching
            if (string.IsNullOrWhiteSpace(route.Location.OriginalString))
                return;

            if (MainPage is Shell shellPage)
                await shellPage.GoToAsync(route, animated);
        }

        public async Task GoToModalAsync<TViewModel, TPage>(object parameter, bool animated = true)
            where TViewModel : IInitializable
            where TPage : Page
        {
            var modalPage = await CreatePageAsync<TViewModel, TPage>(parameter);
            await MainPage.Navigation.PushModalAsync(modalPage, animated);
        }

        public async Task PopAsync(bool animated = true) =>
            await MainPage.Navigation.PopAsync(animated);

        public async Task PopToRootAsync(bool animated = true) =>
            await MainPage.Navigation.PopToRootAsync(animated);

        public async Task PopModalAsync(bool animated = true) =>
            await MainPage.Navigation.PopModalAsync(animated);
        #endregion

        private async Task<TPage> CreatePageAsync<TViewModel, TPage>(object parameter)
            where TViewModel : IInitializable
            where TPage : Page
        {
            var page = Activator.CreateInstance(_routingTable[typeof(TViewModel)]) as TPage;

            var viewModel = Activator.CreateInstance<TViewModel>();
            await viewModel.InitializeAsync(parameter);

            page.BindingContext = viewModel;

            return page;
        }
    }
}
