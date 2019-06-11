using MvvmHelpers;
using System.Threading.Tasks;

namespace XF4.Template.ViewModels.Base
{
    public class ViewModelBase : BaseViewModel, IInitializable
    {
        #region PROPS
        private bool _isVisible;
        public bool IsVisible { get => _isVisible; set => SetProperty(ref _isVisible, value); }
        #endregion

        public virtual async Task InitializeAsync(object parameter) =>
            await Task.CompletedTask;
    }
}
