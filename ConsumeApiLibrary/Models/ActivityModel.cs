namespace ApiLibrary.Models
{
    public class ActivityModel
    {
        // https://www.boredapi.com/api/activity/
        // Provides random Activities you should try out
        public string Activity { get; set; }
        public string Type { get; set; }
        public int Participants { get; set; }
        public double Price { get; set; }
        public string Key { get; set; }
        public string Accessibility { get; set; }
    }
}
