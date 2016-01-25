namespace _04ListView.View
{
    using _04ListView.ViewModel;
    using Xamarin.Forms;

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


            var vm = new MainPageViewModel();
            this.BindingContext = vm;
        }
    }
}
