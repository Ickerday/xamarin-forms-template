using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XF4.Template.Services.Dialog;
using XF4.Template.ViewModels.Base;

namespace XF4.Template.ViewModels.Main
{
    public class MainPageViewModel : ViewModelBase
    {
        #region SERVICES
        private readonly IDialogService _dialogService;
        #endregion

        #region COMMANDS
        private ICommand _showDialogCommand;
        public ICommand ShowDialogCommand => _showDialogCommand
            ?? (_showDialogCommand = new Command<string>(async p => await ExecuteShowDialog(p)));
        #endregion

        public MainPageViewModel(IDialogService dialogService) =>
            _dialogService = dialogService;

        private async Task ExecuteShowDialog(string parameter) =>
            await _dialogService.DisplayInfoAlertAsync(parameter);
    }
}
