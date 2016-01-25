namespace _06DataTemplateSelector.ViewModels
{
    using Base;
    using Model;
    using System.Collections.ObjectModel;

    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<MovieItem> movies;

        public MainViewModel()
        {
            GetMovieData();
        }

        public ObservableCollection<MovieItem> Movies
        {
            get { return this.movies; }
            set
            {
                this.movies = value;
                RaisePropertyChanged();
            }
        }

        private void GetMovieData()
        {
            this.movies = new ObservableCollection<MovieItem>();
            this.movies.Add(new MovieItem()
            {
                Genre = MovieGenreEnum.Action,
                Title = "Indiana Jones and The raiders of the lost ark",
                Description = "In 1936, archaeologist Indiana Jones braves an ancient booby-trapped temple in Peru and retrieves a golden idol. He is confronted by rival archaeologist René Belloq and the indigenous Hovito people. Surrounded and outnumbered, Jones surrenders the idol to Belloq and escapes aboard a waiting floatplane.",
                Picture = "https://upload.wikimedia.org/wikipedia/en/4/4b/Raiders.jpg"
            });
            this.movies.Add(new MovieItem()
            {
                Genre = MovieGenreEnum.Adventures,
                Title = "Lord of the rings, the fellowship of the ring",
                Description = "In the Second Age of Middle Earth, the Dark Lord Sauron forges the One Ring in Mount Doom to conquer all. An alliance of men and elves battle Sauron's forces in Mordor, where Isildur kills Sauron by chopping off the hand wearing the One Ring. Sauron's spirit survives within the ring and corrupts Isildur so that he keeps it instead of destroying it. This decision leads to Isildur's being killed by Orcs, and the ring is lost in the river Anduin for 2500 years. It comes into the possession of Sméagol who is consumed by its power and becomes Gollum. After 500 years the ring abandons him, to be discovered by a Hobbit named Bilbo Baggins.",
                Picture = "https://upload.wikimedia.org/wikipedia/en/0/0c/The_Fellowship_Of_The_Ring.jpg"
            });
            this.movies.Add(new MovieItem()
            {
                Genre = MovieGenreEnum.SciFi,
                Title = "Guardians of the galaxy",
                Description = "In 1988, following his mother's death, a young Peter Quill is abducted from Earth by the Ravagers, a group of space pirates led by Yondu Udonta. Twenty-six years later on the planet Morag, Quill steals an orb, after which Korath, a subordinate to the fanatical Kree, Ronan, intercepts him. Although Quill escapes with the orb, Yondu discovers his theft and issues a bounty for his capture, while Ronan sends the assassin Gamora after the orb.",
                Picture = "https://upload.wikimedia.org/wikipedia/en/8/8f/GOTG-poster.jpg"
            });
        }
    }
}
