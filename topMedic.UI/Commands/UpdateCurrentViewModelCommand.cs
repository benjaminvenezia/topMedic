using System.Windows.Input;
using topMedic.UI.State.Navigators;
using topMedic.UI.ViewModels;

namespace topMedic.UI.Commands;
public class UpdateCurrentViewModelCommand : ICommand
{
    public event EventHandler? CanExecuteChanged;

    private INavigator _navigation;

    public UpdateCurrentViewModelCommand(INavigator navigation)
    {
        _navigation = navigation;
    }

    public bool CanExecute(object? parameter)
    {
        return true;
    }

    public void Execute(object? parameter)
    {
        if (parameter is ViewType)
        {
            ViewType viewType = (ViewType)parameter;
            switch (viewType)
            {
                case ViewType.Appointments:
                    _navigation.CurrentViewModel = new AppointmentViewModel();
                    break;
                case ViewType.Patients:
                    _navigation.CurrentViewModel = new PatientsViewModel();
                    break;
                case ViewType.NewPatient
                    :
                    break;
                case ViewType.NewAppointment
                    :
                    break;
            }
        }
    }
}
