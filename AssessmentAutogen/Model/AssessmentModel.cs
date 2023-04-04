namespace AssessmentAutogen.Model
{
    public class AssessmentModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public List<SectionModel> Sections { get; set; } = new List<SectionModel>();
    }
    public class SectionModel
    {
        public Guid Id { get; set; }
        public string Index { get; set; }
        public string Description { get; set; }
        public List<QuestionModel> Questions { get; set; } = new List<QuestionModel>();
    }
    public class QuestionModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Index { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string SubText { get; set; }
        public string? DefaultValue { get; set; }
        public string QuestionType { get; set; }
        public List<ResponseModel> Choices { get; set; } = new List<ResponseModel>();

        public List<QuestionModel> SubQuestions { get; set; } = new List<QuestionModel>();
    }
    public class ResponseModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid QuestionId { get; set; } = Guid.NewGuid();
        public string Text { get; set; }
        public string Value { get; set; }
    }
}
