using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace irQm.BaseCodes.Configurations
{
    class LongAnswerConfiguration : IEntityTypeConfiguration<LongAnswer>
    {
        public void Configure(EntityTypeBuilder<LongAnswer> builder)
        {
            builder.HasOne(q => q.Lesson).WithMany(l => l.LongAnswers).HasForeignKey(l => l.LessonName).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(q => q.CreatorUser).WithMany(u => u.LongAnswerQuestions).OnDelete(DeleteBehavior.Cascade).HasForeignKey(q=>q.CreatorUserId);

        }
    }
}
