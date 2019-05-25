using System.ComponentModel;

namespace WpfMvvmFody.Model
{
    public class BaseModel : INotifyPropertyChanged // implemented by Fody in build-time
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
