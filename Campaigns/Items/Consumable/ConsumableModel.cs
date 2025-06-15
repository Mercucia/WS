using SQLite;

namespace WS.Campaigns.Items.Consumable
{
    /*
     * Consumable model.
     */
    [Table("consumable")]
    public class ConsumableModel : Item
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string GetName()
        {
            return Identifiers.Name;
        }
    }
}