using XF4.Template.ViewModels.Main;

namespace XF4.Template.Views
{
    public partial class MainPage
    {
        private readonly MainPageViewModel _viewModel;

        public MainPage(MainPageViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = _viewModel = viewModel;
        }

        protected override async void OnAppearing()
        {
            await _viewModel.InitializeAsync(default);

            base.OnAppearing();
        }
    }
}
