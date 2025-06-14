using SQLite;

namespace WS.Campaigns.Characters
{
    /*
     * Class for storing an action.
     */
    [Table("action")]
    public class Action
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public bool BonusAction { get; set; }
        public Identifiers Identifiers { get; set; }

        public string GetName()
        {
            return Identifiers.Name;
        }
    }
}