using System.ComponentModel;
using XF4.Template.ViewModels.Main;

namespace XF4.Template.Views
{
    [DesignTimeVisible(false)]
    public sealed partial class MainPage
    {
        private readonly MainPageViewModel _viewModel;

        public MainPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new MainPageViewModel(); // TODO: Add IoC library
        }

        protected override async void OnAppearing()
        {
            await _viewModel.InitializeAsync(default);

            base.OnAppearing();
        }
    }
}
