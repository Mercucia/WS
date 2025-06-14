using CommunityToolkit.Mvvm.ComponentModel;
using WS.Campaigns.Characters.Action;
using WS.Campaigns.Characters.Stat;
using WS.Campaigns.Items;

namespace WS.Campaigns.Characters.Character
{
    /*
     * Character view model.
     */
    public class CharacterVM : ObservableObject
    {
        private int _id;
        private List<Item> _inventory;
        private List<ActionModel> _actions;
        private List<StatModel> _stats;
        private Identifiers _identifiers;

        public int ID
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }
        public List<Item> Inventory
        {
            get => _inventory;
            set => SetProperty(ref _inventory, value);
        }
        public List<ActionModel> Actions
        {
            get => _actions;
            set => SetProperty(ref _actions, value);
        }
        public List<StatModel> Stats
        {
            get => _stats;
            set => SetProperty(ref _stats, value);
        }
        public Identifiers Identifier
        {
            get => _identifiers;
            set => SetProperty(ref _identifiers, value);
        }

        public CharacterVM(CharacterModel character)
        {
            _id = character.Id;
            _inventory = character.Inventory;
            _actions = character.Actions;
            _stats = character.Stats;
            _identifiers = character.Identifiers;
        }
    }
}