namespace _06DataTemplateSelector.Selector
{
    using Xamarin.Forms;
    using Model;

    public class MovieTemplateSelector : DataTemplateSelector
    {
        private DataTemplate ActionTemplate = (DataTemplate)App.Current.Resources["ActionMovieTemplate"];
        private DataTemplate AdventureTemplate = (DataTemplate)App.Current.Resources["AdventureMovieTemplate"];
        private DataTemplate SciFiTemplate = (DataTemplate)App.Current.Resources["SciFiMovieTemplate"];

        public MovieTemplateSelector()
        {
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item == null)
                return new DataTemplate();

            var movieItem = (MovieItem)item;
            switch (movieItem.Genre)
            {
                case MovieGenreEnum.Action:
                    return this.ActionTemplate;
                case MovieGenreEnum.SciFi:
                    return this.SciFiTemplate;
                case MovieGenreEnum.Adventures:
                    return this.AdventureTemplate;
                default:
                    return new DataTemplate();
            }
        }
    }
}
