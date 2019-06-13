using DryIoc;
using XF4.Template.Services.Dialog;
using XF4.Template.Services.Navigation;
using XF4.Template.ViewModels.Main;
using XF4.Template.Views;

namespace XF4.Template
{
    public static class DependencyContainer
    {
        public static IContainer CreateContainer()
        {
            var container = new Container();

            #region SERVICES
            container.Register<IDialogService, DialogService>();
            container.Register<INavigationService, NavigationService>();
            #endregion

            #region VIEWMODELS
            container.Register<MainPageViewModel>();
            #endregion

            #region PAGES
            container.Register<MainPage>();
            #endregion

            return container;
        }
    }
}
