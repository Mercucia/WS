using SQLite;

namespace WS.Campaigns.Zones
{
    /*
     * Class for storing a map.
     */
    [Table("map")]
    public class Map
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
    }
}