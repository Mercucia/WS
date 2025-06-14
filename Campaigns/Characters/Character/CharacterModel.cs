using SQLite;
using WS.Campaigns.Characters.Action;
using WS.Campaigns.Characters.Stat;
using WS.Campaigns.Items;

namespace WS.Campaigns.Characters.Character
{
    /*
     * Class for storing a character.
     */
    [Table("character")]
    public class CharacterModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public List<Item> Inventory { get; set; }
        public List<ActionModel> Actions { get; set; }
        public List<StatModel> Stats { get; set; }
        public Identifiers Identifiers { get; set; }

        public string GetName()
        {
            return Identifiers.Name;
        }
    }
}