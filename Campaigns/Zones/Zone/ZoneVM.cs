using CommunityToolkit.Mvvm.ComponentModel;
using WS.Campaigns.Zones.Location;

namespace WS.Campaigns.Zones.Zone
{
    /*
     * Zone view model.
     */
    public class ZoneVM : ObservableObject
    {
        private int _id;
        private Identifiers _identifiers;
        private List<LocationVM> _locations;

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

        public List<LocationVM> Locations
        {
            get => _locations;
            set => SetProperty(ref _locations, value);
        }

        public ZoneVM(ZoneModel zone)
        {
            _id = zone.Id;
            _identifiers = zone.Identifiers;
            _locations = zone.Locations;
        }
    }
}