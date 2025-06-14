using SQLite;

namespace WS.Campaigns.Items
{
    /*
     * Class for storing a consumable.
     */
    [Table("consumable")]
    public class Consumable : Item
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string GetName()
        {
            return Identifiers.Name;
        }
    }
}