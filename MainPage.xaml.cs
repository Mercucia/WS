using System.Diagnostics;
using WS.Campaigns.Campaign;

namespace WS
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            BindingContext = App.CampaignViewModel;

            InitializeComponent();
        }

        /*
         * Before the page appears, get and refresh the list of campaigns.
         */
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Dispatcher.DispatchAsync(App.CampaignViewModel.RefreshCampaigns);
        }

        /*
         * Do when the selection changes.
         */
        public void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            App.CampaignViewModel.SelectedCampaign = e.CurrentSelection.FirstOrDefault() as CampaignVM;

            if (App.CampaignViewModel.SelectedCampaign != null)
            {
                Globals.GoToDetails();
            }
        }

        private async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            statusMessage.Text = "";

            await App.CampaignRepo.AddNewCampaign(newCampaign.Text);
            statusMessage.Text = App.CampaignRepo.StatusMessage;

            Debug.WriteLine("saved entry");

            Globals.GoToDetails();
        }

        /*
         * Navigate to the AddNewClient page.
         */
        private async void OnAddNewCampaignButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"addnewcampaign");
        }

        /*
         * Navigate to the ClientList page.
         */
        private async void OnGetAllCampaignsButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"campaignlist");
        }
    }

}
