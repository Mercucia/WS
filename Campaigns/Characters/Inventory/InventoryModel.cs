using SQLite;
using WS.Campaigns.Items;

namespace WS.Campaigns.Characters.Inventory
{
    /*
     * Class for storing an inventory.
     */
    [Table("inventory")]
    public class InventoryModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int Capacity { get; set; }
        public List<Item> Items { get; set; }
    }
}