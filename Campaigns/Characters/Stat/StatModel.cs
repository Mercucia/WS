using SQLite;

namespace WS.Campaigns.Characters.Stat
{
    /*
     * Class for storing a stat.
     */
    [Table("stat")]
    public class StatModel
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