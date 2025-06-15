using SQLite;

namespace WS.Campaigns.Items.Tool
{
    /*
     * Class for storing a tool.
     */
    [Table("tool")]
    public class ToolModel : Item
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string GetName()
        {
            return Identifiers.Name;
        }
    }
}