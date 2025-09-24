using WS.Campaigns.Campaign.Pages;

namespace WS
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("campaign", typeof(MainPage));
            Routing.RegisterRoute("campaign/view", typeof(CampaignView));
            Routing.RegisterRoute("campaign/add", typeof(CampaignView));
        }
    }
}