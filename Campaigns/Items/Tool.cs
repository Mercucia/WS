using SQLite;

namespace WS.Campaigns.Items
{
    /*
     * Class for storing a tool.
     */
    [Table("tool")]
    public class Tool : Item
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string GetName()
        {
            return Identifiers.Name;
        }
    }
}