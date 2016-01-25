namespace _04ListView.ViewModel
{
    using Base;
    using Model;
    using System.Collections.Generic;
    public class MainPageViewModel : ViewModelBase
    {
        private List<Item> items = new List<Item>();

        public MainPageViewModel()
        {
            for (int i = 0; i < 200; i++)
            {
                items.Add(new Item("http://static02.mediaite.com/themarysue/uploads/2015/12/Kylo_Ren.jpg",
                                   string.Format("Item {0}", i),
                                   "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt."));
            }
        }

        public List<Item> Items
        {
            get { return this.items; }
            set
            {
                this.items = value;
                RaisePropertyChanged();
            }
        }
    }
}
