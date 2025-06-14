using SQLite;

namespace WS.Campaigns.Zones
{
    /*
     * Class for storing a Zone.
     */
    [Table("zone")]
    public class Zone
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public Identifiers Identifiers { get; set; }
        public List<Location> Locations { get; set; }

        public string GetName()
        {
            return Identifiers.Name;
        }
    }
}