using SQLite;

namespace WS.Campaigns.Items.Armour
{
    /*
     * Armour model.
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