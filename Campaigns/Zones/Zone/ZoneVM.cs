using SQLite;

<<<<<<< TODO: Unmerged change from project 'WS (net9.0-maccatalyst)', Before:
=======
using WS.Campaigns.Zones.Location;
>>>>>>> After

<<<<<<< TODO: Unmerged change from project 'WS (net9.0-android)', Before:
=======
using WS.Campaigns.Zones.Location;
using WS.Campaigns.Zones.Location.Location;
>>>>>>> After

<<<<<<< TODO: Unmerged change from project 'WS (net9.0-windows10.0.19041.0)', Before:
=======
using WS.Campaigns.Zones.Location;
using WS.Campaigns.Zones.Location.Location;
using WS.Campaigns.Zones.Location.Location.Location;
>>>>>>> After
using WS.Campaigns.Zones.Location.LocationModel;
using WS.Campaigns.Zones.Location.LocationModel.Location;
using WS.Campaigns.Zones.Location.LocationModel.Location.Location;

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
        public List<Location> Locations { get; set; }

        public string GetName()
        {
            return Identifiers.Name;
        }
    }
}