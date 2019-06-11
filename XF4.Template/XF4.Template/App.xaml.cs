using Akavache;
using System.Threading.Tasks;
using XF4.Template.Views;

namespace XF4.Template
{
    public partial class App
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
