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

            OnAddNewCampaignButtonClicked.Clicked += async (s, e) => await Save();
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

        private async Task Save()
        {
            statusMessage.Text = "";

            await App.CampaignRepo.AddNewCampaign(newCampaign.Text);
            statusMessage.Text = App.CampaignRepo.StatusMessage;

            Debug.WriteLine("saved entry");

            Globals.GoToDetails();
        }
    }

}
