namespace AspIntroApp.Models
{
    public class TimelineModel
    {
        public int Order { get; set; }
        public string Content { get; set; }

        public TimelineModel(int order, string content)
        {
            Order = order;
            Content = content;
        }
    }
}
