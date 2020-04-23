using System.Collections.Generic;

namespace OneHundredQuestions_ASP.Net.Models
{
    public class Question
    {
        public long Id { get; }
        public string _Question { get; private set; }
        public List<Answer> Answers { get; private set; }
        public List<Category> Categories { get; private set; }

    }
}