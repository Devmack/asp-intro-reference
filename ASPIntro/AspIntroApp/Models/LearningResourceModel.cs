namespace AspIntroApp.Models
{
    public class LearningResourceModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
        public LearningCategory Category { get; set; }
        public float Difficulty { get; set; }

        public LearningResourceModel(string name, string description, string uRL, LearningCategory category, float difficulty)
        {
            Name = name;
            Description = description;
            URL = uRL;
            Category = category;
            Difficulty = difficulty;
        }

        public LearningResourceModel(string name)
        {
            Name = name;
        }
    }
}
