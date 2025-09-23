namespace WS
{
    public static class Globals
    {
        public const string DB = "campaigns.db3";

        public static string GetPath(string fileName)
        {
            return System.IO.Path.Combine(FileSystem.AppDataDirectory, fileName);
        }

        /*
         * Go to a details page.
         */
        public static async void GoToDetails()
        {
            await Shell.Current.GoToAsync("view");
        }
    }
}