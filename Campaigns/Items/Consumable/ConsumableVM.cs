using CommunityToolkit.Mvvm.ComponentModel;

namespace WS.Campaigns.Items.Consumable
{
    /*
     * Consumable view model.
     */
    public class ConsumableVM : ObservableObject
    {
        private int _id;

        public int ID
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        public ConsumableVM(ConsumableModel consumable)
        {
            _id = consumable.Id;
        }
    }
}