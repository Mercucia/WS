using SQLite;

namespace WS.Campaigns.Zones.Location
{
    /*
     * Location model.
     */
    [Table("location")]
    public class LocationModel
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