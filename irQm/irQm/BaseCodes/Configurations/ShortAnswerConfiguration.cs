using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace irQm.BaseCodes.Configurations
{
    class ShortAnswerConfiguration : IEntityTypeConfiguration<ShortAnswer>
    {
        public void Configure(EntityTypeBuilder<ShortAnswer> builder)
        {
            builder.HasOne(q => q.Lesson).WithMany(l => l.ShortAnswers).HasForeignKey(l => l.LessonName).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(q => q.CreatorUser).WithMany(u => u.ShortAnswerQuestions).OnDelete(DeleteBehavior.Cascade).HasForeignKey(q => q.CreatorUserId);

        }
    }
}
