using SQLite;
using WS.Campaigns.Characters.Character;
using WS.Campaigns.Items;
using WS.Campaigns.Zones.Zone;

namespace WS.Campaigns
{
    /*
     * CampaignModel model.
     */
    [Table("campaign")]
    public class CampaignModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public Identifiers Identifiers { get; set; }
        public List<ZoneVM> Zones { get; set; }
        public List<CharacterVM> Characters { get; set; }
        public List<Item> Items { get; set; }

        public string GetName()
        {
            return Identifiers.Name;
        }
    }
}