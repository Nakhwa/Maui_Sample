using CommunityToolkit.Mvvm.Input;
using Maui_Sample.Models;

namespace Maui_Sample.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}