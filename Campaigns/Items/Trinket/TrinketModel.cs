using SQLite;

namespace WS.Campaigns.Items.Trinket
{
    /*
     * Trinket model.
     */
    [Table("trinket")]
    public class TrinketModel : Item
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string GetName()
        {
            return Identifiers.Name;
        }
    }
}