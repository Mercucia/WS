using CommunityToolkit.Mvvm.ComponentModel;

namespace WS.Campaigns.Items.Armour
{
    /*
     * Armour view model.
     */
    public class ArmourVM : ObservableObject
    {
        private int _id;

        public int ID
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        public ArmourVM(ArmourModel armour)
        {
            _id = armour.Id;
        }
    }
}