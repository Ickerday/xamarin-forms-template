using System.Threading.Tasks;
using XF4.Template.ViewModels.Base;

namespace XF4.Template.ViewModels.Main
{
    public class MainPageViewModel : ViewModelBase
    {
        public override Task InitializeAsync(object parameter)
        {
            Title = nameof(MainPageViewModel);

            return base.InitializeAsync(parameter);
        }
    }
}
