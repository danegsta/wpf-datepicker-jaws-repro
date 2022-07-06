using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppDatePickerRepro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = new MainWindowViewModel();

            // Handle the GotFocus event on AccountExpirationDatePicker. Simply adding event handler doesn't work when user uses mouse to select the datepicker text box.
            // This is the workaround.
            AccountExpirationDatePicker.AddHandler(DatePicker.GotFocusEvent, new RoutedEventHandler(AccountExpirationDatePicker_GotFocus), true);
        }

        private void AccountExpirationDatePicker_GotFocus(object sender, RoutedEventArgs e)
        {
            e.Handled = false;
        }
    }
}
