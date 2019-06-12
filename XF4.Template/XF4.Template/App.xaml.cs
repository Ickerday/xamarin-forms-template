using Akavache;
using DryIoc;
using System.Threading.Tasks;
using Xamarin.Forms;
using XF4.Template.ViewModels.Main;
using XF4.Template.Views;

namespace XF4.Template
{
    public partial class App
    {
        public readonly IContainer Container;

        public App()
        {
            Container = DependencyContainer.CreateContainer();

            InitializeComponent();

            MainPage = new NavigationPage(new MainPage(Container.Resolve<MainPageViewModel>()));
        }

        protected override void OnStart() =>
            Registrations.Start(nameof(Template));

        // Handle when your app sleeps
        protected override async void OnSleep() =>
            await Task.CompletedTask;

        // Handle when your app resumes
        protected override async void OnResume() =>
            await Task.CompletedTask;
    }
}
