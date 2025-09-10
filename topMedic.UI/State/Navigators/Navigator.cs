using System.Windows.Input;
using topMedic.UI.Commands;
using topMedic.UI.Models;
using topMedic.UI.ViewModels;

namespace topMedic.UI.State.Navigators;
public class Navigator : ObservableObject, INavigator
{
    private ViewModelBase _currentViewModel;
    public ViewModelBase CurrentViewModel
    {
        get
        {
            return _currentViewModel;
        }

        set
        {
            _currentViewModel = value;
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }

    public ICommand UpdateCurrentViewModelCommand => new UpdateCurrentViewModelCommand(this);


}
