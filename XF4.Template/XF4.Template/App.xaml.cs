using Akavache;
using System.Threading.Tasks;

namespace XF4.Template
{
    public partial class App
    {
        public App() => InitializeComponent();

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
