using System.Windows.Input;
using topMedic.UI.ViewModels;

namespace topMedic.UI.State.Navigators;

public enum ViewType
{
    Appointments,
    Patients,
    NewAppointment,
    NewPatient,

}

public interface INavigator
{  
    ViewModelBase CurrentViewModel { get; set; }
    ICommand UpdateCurrentViewModelCommand { get; }
}
