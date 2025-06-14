using SQLite;

namespace WS.Campaigns
{
    /*
     * Class for storing identifiers.
     */
    [Table("identifiers")]
    public class Identifiers
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(60)]
        public string Name { get; set; }
        [MaxLength(120)]
        public string Description { get; set; }
    }
}