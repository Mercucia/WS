using SQLite;

namespace WS.Campaigns.Items.Armour
{
    /*
     * Class for storing an armour.
     */
    [Table("armour")]
    public class ArmourModel : Item
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string GetName()
        {
            return Identifiers.Name;
        }
    }
}