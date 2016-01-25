using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace _04ListView.Model.Base
{
    public class BindableBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged([CallerMemberName]string propertyName = "")
        {
            var tmpHandler = PropertyChanged;
            if (tmpHandler != null)
                tmpHandler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
