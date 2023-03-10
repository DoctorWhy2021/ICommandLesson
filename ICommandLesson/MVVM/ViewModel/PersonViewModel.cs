using ICommandLesson.Core;

namespace ICommandLesson.MVVM.ViewModel;

public class PersonViewModel: ObservableObject
{
    private string _name;

    public string Name
    {
        get
        {
            if (string.IsNullOrEmpty(_name))
                return "Unknown";
            
            return _name;
        }
        set
        {
            _name = value;
            OnPropertyChanged("Name");
        }
    }
}