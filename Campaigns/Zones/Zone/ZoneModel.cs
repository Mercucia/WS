using SQLite;
using WS.Campaigns.Zones.Location;

namespace WS.Campaigns.Zones.Zone
{
    /*
     * Class for storing a Zone.
     */
    [Table("zone")]
    public class ZoneModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public Identifiers Identifiers { get; set; }
        public List<LocationVM> Locations { get; set; }

        public string GetName()
        {
            return Identifiers.Name;
        }
    }
}