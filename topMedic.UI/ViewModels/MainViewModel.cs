using topMedic.UI.State.Navigators;

namespace topMedic.UI.ViewModels;
public class MainViewModel : ViewModelBase
{
    public INavigator Navigator { get; set; } = new Navigator();


}
