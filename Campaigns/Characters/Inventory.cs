using SQLite;
using WS.Campaigns.Items;

namespace WS.Campaigns.Characters
{
    /*
     * Class for storing an inventory.
     */
    [Table("inventory")]
    public class Inventory
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int Capacity { get; set; }
        public List<Item> Items { get; set; }
    }
}