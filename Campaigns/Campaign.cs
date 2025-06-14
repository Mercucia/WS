using SQLite;
using WS.Campaigns.Characters.Character;
using WS.Campaigns.Items;
using WS.Campaigns.Zones;

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
        public List<Zone> Zones { get; set; }
        public List<CharacterModel> Characters { get; set; }
        public List<Item> Items { get; set; }

        public string GetName()
        {
            return Identifiers.Name;
        }
    }
}