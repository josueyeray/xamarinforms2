namespace _07ControlTemplate
{
    using Views;
    using Xamarin.Forms;
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new MainView();
        }
    }
}
