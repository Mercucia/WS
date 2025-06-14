using CommunityToolkit.Mvvm.ComponentModel;

namespace WS.Campaigns.Characters.BonusAction
{
    /*
     * Bonus action view model.
     */
    public class BonusActionVM : ObservableObject
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

        public BonusActionVM(BonusActionModel bonusAction)
        {
            _id = bonusAction.Id;
            _identifiers = bonusAction.Identifiers;
        }
    }
}