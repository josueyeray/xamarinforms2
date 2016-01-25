namespace _05Effects.WinPhone.Effects
{
    using System.Windows;
    using System.Windows.Media;
    using Xamarin.Forms.Platform.WinPhone;

    public class FocusEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            Control.GotFocus += Control_GotFocus;
            Control.LostFocus += Control_LostFocus;
        }

        protected override void OnDetached()
        {
            Control.GotFocus -= Control_GotFocus;
            Control.LostFocus -= Control_LostFocus;
        }

        private void Control_LostFocus(object sender, System.Windows.RoutedEventArgs e)
        {
            (Control as System.Windows.Controls.Control).Background = new SolidColorBrush(Colors.White);
        }

        private void Control_GotFocus(object sender, System.Windows.RoutedEventArgs e)
        {
            (Control as System.Windows.Controls.Control).Background = new SolidColorBrush(Colors.Cyan);
        }
    }
}
