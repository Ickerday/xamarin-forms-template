using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF4.Template.Services.Dialog
{
    public interface IDialogService
    {
        Task DisplayInfoAlertAsync(string message);

        Task DisplayErrorAlertAsync(string message);

        Task DisplayCustomAlertAsync(string title, string message);

        Task DisplayCustomAlertAsync(string title, string message, string confirm);

        Task<bool> DisplayConfirmationAlertAsync(string title, string message);

        Task<bool> DisplayConfirmationAlertAsync(string title, string message, string accept, string cancel);

        Task<string> DisplayActionSheet(string title, string destruction, params string[] buttons);
    }

    public class DialogService : IDialogService
    {
        private static Page MainPage => Application.Current.MainPage;

        public async Task DisplayInfoAlertAsync(string message) =>
            await MainPage.DisplayAlert("Info", message, "Ok");

        public async Task DisplayErrorAlertAsync(string message) =>
            await MainPage.DisplayAlert("Error", message, "O");

        public async Task DisplayCustomAlertAsync(string title, string message) =>
            await MainPage.DisplayAlert(title, message, "Ok");

        public async Task DisplayCustomAlertAsync(string title, string message, string confirm) =>
            await MainPage.DisplayAlert(title, message, confirm);

        public async Task<bool> DisplayConfirmationAlertAsync(string title, string message) =>
            await MainPage.DisplayAlert(title, message, "Confirm", "Cancel");

        public async Task<bool> DisplayConfirmationAlertAsync(string title, string message, string accept, string cancel) =>
            await MainPage.DisplayAlert(title, message, accept, cancel);

        public async Task<string> DisplayActionSheet(string title, string destruction, params string[] buttons) =>
            await MainPage.DisplayActionSheet(title, "Cancel", destruction, buttons);
    }
}
