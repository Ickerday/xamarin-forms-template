using System.Threading.Tasks;

namespace XF4.Template.ViewModels.Base
{
    public interface IInitializable
    {
        Task InitializeAsync(object parameter);
    }
}
