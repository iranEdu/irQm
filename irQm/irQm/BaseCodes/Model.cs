using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

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
       // public DbSet<Tag> Tags { get; set; }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<QuestionInList<TFQuestion>>().HasOne(q => q.Question).WithMany().OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<QuestionInList<MultiChoices>>().HasOne(q => q.Question).WithMany().OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<QuestionInList<ShortAnswer>>().HasOne(q => q.Question).WithMany().OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<QuestionInList<LongAnswer>>().HasOne(q => q.Question).WithMany().OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<QuestionInList<Practical>>().HasOne(q => q.Question).WithMany().OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<QuestionInList<Puzzle>>().HasOne(q => q.Question).WithMany().OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<Exam>().HasMany(ql => ql.TFQuestions).WithOne().OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Exam>().HasMany(ql => ql.ShortAnswerQuestions).WithOne().OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Exam>().HasMany(ql => ql.LongAnswerQuestions).WithOne().OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Exam>().HasMany(ql => ql.PracticalQuestions).WithOne().OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Exam>().HasMany(ql => ql.MultiChoicesQuestions).WithOne().OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Exam>().HasMany(ql => ql.PuzzleQuestions).WithOne().OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Puzzle>().HasMany(p=>p.Pairs).WithOne().HasForeignKey("PuzzlePairs").OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Puzzle>().HasMany(p => p.AnswerPairs).WithOne().HasForeignKey("PuzzleAnswerPairs").OnDelete(DeleteBehavior.Cascade);

            
            modelBuilder.Entity<TFQuestion>().HasOne(q => q.Lesson).WithMany(l => l.TFQuestions).HasForeignKey(l=>l.LessonName).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<MultiChoices>().HasOne(q => q.Lesson).WithMany(l => l.MultiChoicesQusestions).HasForeignKey(l => l.LessonName).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<LongAnswer>().HasOne(q => q.Lesson).WithMany(l => l.LongAnswers).HasForeignKey(l => l.LessonName).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<ShortAnswer>().HasOne(q => q.Lesson).WithMany(l => l.ShortAnswers).HasForeignKey(l => l.LessonName).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Practical>().HasOne(q => q.Lesson).WithMany(l => l.Practicals).HasForeignKey(l => l.LessonName).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Puzzle>().HasOne(q => q.Lesson).WithMany(l => l.Puzzles).HasForeignKey(l => l.LessonName).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<MultiChoices>().HasMany(q => q.Options).WithOne().OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<TFQuestion>().HasOne(q => q.FalseOption).WithOne().HasForeignKey<TFOption>(o=>o.Id).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<TFQuestion>().HasOne(q => q.TrueOption).WithOne().HasForeignKey<TFOption>(o => o.Id).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Puzzle>().HasMany(q => q.Pairs).WithOne().OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Puzzle>().HasMany(q => q.AnswerPairs).WithOne().OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Puzzle>().HasMany(q => q.ExtraAnswers).WithOne().OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<TagInQuestion<TFQuestion>>().HasKey(tiq => new { tiq.TagId, tiq.QuestionId });
            modelBuilder.Entity<TagInQuestion<MultiChoices>>().HasKey(tiq => new { tiq.TagId, tiq.QuestionId });
            modelBuilder.Entity<TagInQuestion<ShortAnswer>>().HasKey(tiq => new { tiq.TagId, tiq.QuestionId });
            modelBuilder.Entity<TagInQuestion<LongAnswer>>().HasKey(tiq => new { tiq.TagId, tiq.QuestionId });
            modelBuilder.Entity<TagInQuestion<Practical>>().HasKey(tiq => new { tiq.TagId, tiq.QuestionId });
            modelBuilder.Entity<TagInQuestion<Puzzle>>().HasKey(tiq => new { tiq.TagId, tiq.QuestionId });

            modelBuilder.Entity<TagInQuestion<TFQuestion>>().HasOne(tiq=>tiq.Question).WithMany(q=>q.Tags).HasForeignKey(tiq=>tiq.QuestionId);
            modelBuilder.Entity<TagInQuestion<MultiChoices>>().HasOne(tiq=>tiq.Question).WithMany(q=>q.Tags).HasForeignKey(tiq=>tiq.QuestionId);
            modelBuilder.Entity<TagInQuestion<Practical>>().HasOne(tiq => tiq.Question).WithMany(q => q.Tags).HasForeignKey(tiq => tiq.QuestionId);
            modelBuilder.Entity<TagInQuestion<Puzzle>>().HasOne(tiq => tiq.Question).WithMany(q => q.Tags).HasForeignKey(tiq => tiq.QuestionId);
            modelBuilder.Entity<TagInQuestion<ShortAnswer>>().HasOne(tiq => tiq.Question).WithMany(q => q.Tags).HasForeignKey(tiq => tiq.QuestionId);
            modelBuilder.Entity<TagInQuestion<LongAnswer>>().HasOne(tiq => tiq.Question).WithMany(q => q.Tags).HasForeignKey(tiq => tiq.QuestionId);

            modelBuilder.Entity<TagInQuestion<TFQuestion>>().HasOne(tiq=>tiq.Tag).WithMany().HasForeignKey(tiq=>tiq.TagId);
            modelBuilder.Entity<TagInQuestion<MultiChoices>>().HasOne(tiq => tiq.Tag).WithMany().HasForeignKey(tiq => tiq.TagId);
            modelBuilder.Entity<TagInQuestion<Puzzle>>().HasOne(tiq => tiq.Tag).WithMany().HasForeignKey(tiq => tiq.TagId);
            modelBuilder.Entity<TagInQuestion<Practical>>().HasOne(tiq => tiq.Tag).WithMany().HasForeignKey(tiq => tiq.TagId);
            modelBuilder.Entity<TagInQuestion<LongAnswer>>().HasOne(tiq => tiq.Tag).WithMany().HasForeignKey(tiq => tiq.TagId);
            modelBuilder.Entity<TagInQuestion<ShortAnswer>>().HasOne(tiq => tiq.Tag).WithMany().HasForeignKey(tiq => tiq.TagId);

            modelBuilder.Entity<Exam>().HasKey(e => new { e.Id, e.Username });

            modelBuilder.Entity<Exam>().HasOne<User>().WithMany().HasForeignKey(e => e.Username);

            modelBuilder.Entity<MultiChoices>().Property(m => m.MultiSelections).HasField("multiSelection");

            //modelBuilder.Entity<TagInQuestion>().HasMany(t => ).WithOne<>().OnDelete(DeleteBehavior.Cascade);





        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=db.db");
        }
    }
}
