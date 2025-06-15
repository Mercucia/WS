using SQLite;

namespace WS.Campaigns.Items.Weapon
{
    /*
     * Weapon model.
     */
    [Table("weapon")]
    public class WeaponModel : Item
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string GetName()
        {
            return Identifiers.Name;
        }
    }
}