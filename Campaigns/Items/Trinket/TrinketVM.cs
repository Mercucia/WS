using CommunityToolkit.Mvvm.ComponentModel;

namespace WS.Campaigns.Items.Trinket
{
    /*
     * Trinket view model.
     */
    public class TrinketVM : ObservableObject
    {
        private int _id;

        public int ID
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        public TrinketVM(TrinketModel trinket)
        {
            _id = trinket.Id;
        }
    }
}