using System.Threading.Tasks;

namespace XF4.Template.Services.Navigation
{
    public interface IInitializable
    {
        Task InitializeAsync(object parameter = null);
    }
}
