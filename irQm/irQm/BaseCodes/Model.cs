using Microsoft.EntityFrameworkCore;

namespace irQm.BaseCodes
{
    class irQmDbContext:DbContext
    {
      public  DbSet<TFQuestion> TFQuestions { get; set; }
        public DbSet<MultiChoices> MultiChoicesQuestions { get; set; }
        public DbSet<LongAnswer> LongAnswerQuestions { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Puzzle> PuzzleQuestions { get; set; }
        public DbSet<Practical> PracticalQuestions { get; set;}
        public DbSet<ShortAnswer> ShortAnswerQustions { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<string> Tags { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
