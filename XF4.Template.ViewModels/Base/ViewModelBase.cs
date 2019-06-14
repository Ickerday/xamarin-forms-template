using MvvmHelpers;
using System.Threading.Tasks;
using XF4.Template.Services.Dialog;

namespace XF4.Template.ViewModels.Base
{
    public class ViewModelBase : BaseViewModel
    {
        #region SERVICES
        protected readonly IDialogService DialogService;
        #endregion

        #region PROPS
        private bool _isVisible;
        public bool IsVisible { get => _isVisible; set => SetProperty(ref _isVisible, value); }
        #endregion

        public ViewModelBase(IDialogService dialogService) =>
            DialogService = dialogService;

        public virtual async Task InitializeAsync(object parameter) =>
            await Task.CompletedTask;
    }
}
