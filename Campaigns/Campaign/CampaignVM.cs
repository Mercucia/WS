using CommunityToolkit.Mvvm.ComponentModel;
using WS.Campaigns.Characters.Character;
using WS.Campaigns.Items;
using WS.Campaigns.Zones.Zone;

namespace WS.Campaigns
{
    /*
     * CampaignModel view model.
     */
    public class CampaignVM : ObservableObject
    {
        private int _id;
        private Identifiers _identifiers;
        private List<ZoneVM> _zones;
        private List<CharacterVM> _characters;
        private List<Item> _items;

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

        public List<ZoneVM> Zones
        {
            get => _zones;
            set => SetProperty(ref _zones, value);
        }

        public List<CharacterVM> Characters
        {
            get => _characters;
            set => SetProperty(ref _characters, value);
        }

        public List<Item> Items
        {
            get => _items;
            set => SetProperty(ref _items, value);
        }

        public CampaignVM(CampaignModel campaign)
        {
            _id = campaign.Id;
            _identifiers = campaign.Identifiers;
            _zones = campaign.Zones;
            _characters = campaign.Characters;
            _items = campaign.Items;
        }
    }
}