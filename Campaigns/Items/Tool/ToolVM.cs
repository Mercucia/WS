using CommunityToolkit.Mvvm.ComponentModel;

namespace WS.Campaigns.Items.Tool
{
    /*
     * Tool view model.
     */
    public class ToolVM : ObservableObject
    {
        private int _id;

        public int ID
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        public ToolVM(ToolModel tool)
        {
            _id = tool.Id;
        }
    }
}