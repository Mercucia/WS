using SQLite;

namespace WS.Campaigns.Items.Weapon
{
    /*
     * Class for storing a weapon.
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