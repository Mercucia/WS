using SQLite;

namespace WS.Campaigns.Characters.BonusAction
{
    /*
     * Class for storing a bonus action.
     */
    [Table("bonusAction")]
    public class BonusActionModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public Identifiers Identifiers { get; set; }

        public string GetName()
        {
            return Identifiers.Name;
        }
    }
}