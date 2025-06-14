using CommunityToolkit.Mvvm.ComponentModel;

namespace WS.Campaigns.Characters.Action
{
    /*
     * Action view model.
     */
    public class ActionVM : ObservableObject
    {
        private int _id;
        private bool _bonusAction;
        private Identifiers _identifiers;

        public int ID
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        public bool BonusAction
        {
            get => _bonusAction;
            set => SetProperty(ref _bonusAction, value);
        }

        public Identifiers Identifiers
        {
            get => _identifiers;
            set => SetProperty(ref _identifiers, value);
        }

        public ActionVM(ActionModel action)
        {
            _id = action.Id;
            _bonusAction = action.BonusAction;
            _identifiers = action.Identifiers;
        }
    }
}