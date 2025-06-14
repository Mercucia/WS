using SQLite;

namespace WS.Campaigns.Items
{
    /*
     * Class for storing an item.
     */
    [Table("item")]
    public abstract class Item
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public Identifiers Identifiers { get; set; }
        public int Value { get; set; }
        public int Mass { get; set; }
        public int Uses { get; set; }
    }
}