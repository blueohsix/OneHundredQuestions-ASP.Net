using Microsoft.EntityFrameworkCore;
using OneHundredQuestions_ASP.Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneHundredQuestions_ASP.Net.Data
{
    public class OneHundredQuestionsDataContext: DbContext
    {
        public DbSet<Answer> Answer { get; set; }
        public DbSet<EndUser> EndUser { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<Category> Category { get; set; }

        public OneHundredQuestionsDataContext(DbContextOptions<OneHundredQuestionsDataContext> options)
            :base(options)
        {
            Database.Migrate();
            //Database.EnsureCreated()
        }
    }
}
