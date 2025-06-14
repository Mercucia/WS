using CommunityToolkit.Mvvm.ComponentModel;
using WS.Campaigns.Items;

namespace WS.Campaigns.Characters.Inventory
{
    /*
     * Inventory view model.
     */
    public class InventoryVM : ObservableObject
    {
        private int _id;
        public int _capacity;
        public List<Item> _items;

        public int ID
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        public int Capacity
        {
            get => _capacity;
            set => SetProperty(ref _capacity, value);
        }

        public List<Item> Items
        {
            get => _items;
            set => SetProperty(ref _items, value);
        }

        public InventoryVM(InventoryModel inventory)
        {
            _id = inventory.Id;
            _capacity = inventory.Capacity;
            _items = inventory.Items;
        }
    }
}