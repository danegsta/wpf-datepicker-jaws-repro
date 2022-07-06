using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfAppDatePickerRepro
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private DateTime? _accountExpirationDate = DateTime.UtcNow;

        public event PropertyChangedEventHandler PropertyChanged;

        public DateTime? AccountExpirationDate
        {
            get
            {
                return _accountExpirationDate;
            }

            set
            {
                if (_accountExpirationDate != value)
                {
                    _accountExpirationDate = value;
                    OnPropertyChanged(nameof(AccountExpirationDate));
                }
            }
        }

        // Create the OnPropertyChanged method to raise the event
        // The calling member's name will be used as the parameter.
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
