using SQLite;

namespace WS.Campaigns.Items
{
    /*
     * Class for storing a trinket.
     */
    [Table("trinket")]
    public class Trinket : Item
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string GetName()
        {
            return Identifiers.Name;
        }
    }
}