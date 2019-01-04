using System.ComponentModel;

namespace BlazorMVVM.Models
{
    public class ToggleViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private bool _toggle = true;

        public void ToggleIt()
        {
            Toggle = !Toggle;
        }

        public bool Toggle
        {
            get => _toggle;
            set
            {
                if (value != _toggle)
                {
                    _toggle = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Toggle)));
                }
            }
        }
    }
}
