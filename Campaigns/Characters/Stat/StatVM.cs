using CommunityToolkit.Mvvm.ComponentModel;

namespace WS.Campaigns.Characters.Stat
{
    /*
     * Stat view model.
     */
    public class StatVM : ObservableObject
    {
        private int _id;
        private Identifiers _identifiers;

        public int ID
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        public Identifiers Identifiers
        {
            get => _identifiers;
            set => SetProperty(ref _identifiers, value);
        }

        public StatVM(StatModel stat)
        {
            _id = stat.Id;
            _identifiers = stat.Identifiers;
        }
    }
} 