using SQLite;
using WS.Campaigns.Items;

namespace WS.Campaigns.Characters
{
    /*
     * Class for storing a character.
     */
    [Table("character")]
    public class Character
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public List<Item> Inventory { get; set; }
        public List<Action> Actions { get; set; }
        public List<Stat> Stats { get; set; }
        public Identifiers Identifiers { get; set; }

        public string GetName()
        {
            return Identifiers.Name;
        }
    }
}