using SQLite;

namespace WS.Campaigns.Zones
{
    /*
     * Class for storing a location.
     */
    [Table("location")]
    public class Location
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