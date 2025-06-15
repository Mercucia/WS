using SQLite;
using WS.Campaigns.Characters.Character;
using WS.Campaigns.Items;

<<<<<<< TODO: Unmerged change from project 'WS (net9.0-maccatalyst)', Before:
=======
using WS.Campaigns.Zones.Zone;
>>>>>>> After

<<<<<<< TODO: Unmerged change from project 'WS (net9.0-android)', Before:
=======
using WS.Campaigns.Zones.Zone;
using WS.Campaigns.Zones.Zone.Zone;
>>>>>>> After

<<<<<<< TODO: Unmerged change from project 'WS (net9.0-windows10.0.19041.0)', Before:
=======
using WS.Campaigns.Zones.Zone;
using WS.Campaigns.Zones.Zone.Zone;
using WS.Campaigns.Zones.Zone.Zone.Zone;
>>>>>>> After
using WS.Campaigns.Zones.Zone;
using WS.Campaigns.Zones.Zone.ZoneModel;
using WS.Campaigns.Zones.Zone.ZoneModel.Zone;
using WS.Campaigns.Zones.Zone.ZoneModel.Zone.Zone;

namespace WS.Campaigns
{
    /*
     * Class for storing a campaign.
     */
    [Table("campaign")]
    public class Campaign
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public Identifiers Identifiers { get; set; }
        public List<ZoneModel> Zones { get; set; }
        public List<CharacterModel> Characters { get; set; }
        public List<Item> Items { get; set; }

        public string GetName()
        {
            return Identifiers.Name;
        }
    }
}