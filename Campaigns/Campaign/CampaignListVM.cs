using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace WS.Campaigns.Campaign
{
    /*
     * CampaignModel view model.
     */
    public class CampaignListVM : ObservableObject
    {
        public ICommand DeleteCampaignCommand { get; private set; }
        public ObservableCollection<CampaignVM> Campaigns { get; set; }

        public CampaignListVM()
        {
            Campaigns = [];
            DeleteCampaignCommand = new Command<CampaignVM>(DeleteCampaign);
        }

        private CampaignVM? _selectedCampaign;

        public CampaignVM? SelectedCampaign
        {
            get => _selectedCampaign;
            set => SetProperty(ref _selectedCampaign, value);
        }

        /*
         * Refresh the visible list of campaigns when data is changed.
         */
        public async Task RefreshCampaigns()
        {
            IEnumerable<CampaignModel> campaignData = await App.CampaignRepo.GetAllCampaigns();

            foreach (CampaignModel campaign in campaignData)
            {
                Campaigns.Add(new CampaignVM(campaign));
            }
        }

        /*
         * Delete a client from the database.
         */
        public async void OnDeleteCampaign(int id)
        {
            await App.CampaignRepo.DeleteCampaign(id);
        }

        /*
         * Delete a client from the list.
         */
        public void DeleteCampaign(CampaignVM campaign)
        {
            OnDeleteCampaign(campaign.ID);
            Campaigns.Remove(campaign);
        }
    }
}