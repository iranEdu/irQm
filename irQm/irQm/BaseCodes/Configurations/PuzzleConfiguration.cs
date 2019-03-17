using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace irQm.BaseCodes.Configurations
{
    class PuzzleConfiguration : IEntityTypeConfiguration<Puzzle>
    {
        public void Configure(EntityTypeBuilder<Puzzle> builder)
        {
            
            builder.HasMany(p => p.Pairs).WithOne().HasForeignKey("PuzzlePairs").OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(p => p.AnswerPairs).WithOne().HasForeignKey("PuzzleAnswerPairs").OnDelete(DeleteBehavior.Cascade);

            //builder.HasMany(q => q.Pairs).WithOne().OnDelete(DeleteBehavior.Cascade);
            //builder.HasMany(q => q.AnswerPairs).WithOne().OnDelete(DeleteBehavior.Cascade);
            //builder.HasMany(q => q.ExtraAnswers).WithOne().OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(q => q.CreatorUser).WithMany(u => u.PuzzleQuestions).OnDelete(DeleteBehavior.Cascade).HasForeignKey(q => q.CreatorUserId);

            builder.HasOne(q => q.Lesson).WithMany(l => l.Puzzles).HasForeignKey(l => l.LessonName).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
