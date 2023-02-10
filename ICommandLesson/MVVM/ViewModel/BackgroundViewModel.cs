using System.Windows.Media;
using ICommandLesson.Core;

namespace ICommandLesson.MVVM.ViewModel;

public class BackgroundViewModel : ObservableObject
{
    private Brush _color;

    public Brush Color
    {
        get
        {
            if (_color == null)
                return Brushes.Green;

            return _color;
        }
        set
        {
            _color = value;
            OnPropertyChanged("Color");
        }
    }
}