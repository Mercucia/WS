using CommunityToolkit.Mvvm.ComponentModel;

namespace WS.Campaigns.Items.Weapon
{
    /*
     * Class for storing a weapon.
     */
    public class WeaponVM : ObservableObject
    {
        private int _id;

        public int ID
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        public WeaponVM(WeaponModel weapon)
        {
            _id = weapon.Id;
        }
    }
}