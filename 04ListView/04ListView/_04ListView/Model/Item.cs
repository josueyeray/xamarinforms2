namespace _04ListView.Model
{
    using Base;

    public class Item : BindableBase
    {
        private string imageUri;
        private string title;
        private string description;

        public Item()
        {
        }

        public Item(string imageUri, string title, string description)
        {
            this.imageUri = imageUri;
            this.title = title;
            this.description = description;
        }

        public string ImageUri
        {
            get { return this.imageUri; }
            set
            {
                this.imageUri = value;
                RaisePropertyChanged();
            }
        }

        public string Title
        {
            get { return this.title; }
            set
            {
                this.title = value;
                RaisePropertyChanged();
            }
        }

        public string Description
        {
            get { return this.description; }
            set
            {
                this.description = value;
                RaisePropertyChanged();
            }
        }
    }
}
