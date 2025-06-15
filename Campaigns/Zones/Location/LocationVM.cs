using CommunityToolkit.Mvvm.ComponentModel;

namespace WS.Campaigns.Zones.Location
{
    /*
     * Location view model.
     */
    public class LocationVM : ObservableObject
    {
        private int _id;
        private Identifiers _identifiers;

        public int ID
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        public Identifiers Identifiers
        {
            get => _identifiers;
            set => SetProperty(ref _identifiers, value);
        }

        public LocationVM(LocationModel location)
        {
            _id = location.Id;
            _identifiers = location.Identifiers;
        }
    }
}