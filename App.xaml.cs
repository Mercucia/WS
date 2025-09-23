using WS.Campaigns.Campaign;

namespace WS
{
    public partial class App : Application
    {
        public static Repository CampaignRepo { get; private set; }
        public static CampaignListVM? CampaignViewModel { get; private set; }

        public App(Repository repo)
        {
            InitializeComponent();
            CampaignRepo = repo;
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = new Window(new AppShell());

            CampaignViewModel = new();
            CampaignViewModel.RefreshCampaigns().ContinueWith((s) => { });

            return window;
        }
    }
}