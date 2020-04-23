namespace OneHundredQuestions_ASP.Net.Models
{
    public class Answer
    {
        public long Id { get; private set; }
        public string _Answer { get; set; }
        public int QuestionId { get; set; }
        public int EndUserId { get; set; }

        public Answer(string answer, int questionId, int endUserId)
        {
            _Answer = answer;
            QuestionId = QuestionId;
            EndUserId = endUserId;
        }
    }
}