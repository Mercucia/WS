using SQLite;

namespace WS.Campaigns.Items.Consumable
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