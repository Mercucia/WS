using SQLite;

namespace WS.Campaigns.Items
{
    /*
     * Class for storing an armour.
     */
    [Table("armour")]
    public class Armour : Item
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string GetName()
        {
            return Identifiers.Name;
        }
    }
}