using System.Collections.Generic;

namespace OneHundredQuestions_ASP.Net.Models
{
    public class Category
    {
        public int Id { get; private set; }
        public string _category { get; private set; }
        public List<Question> Questions { get; private set; }
    }
}