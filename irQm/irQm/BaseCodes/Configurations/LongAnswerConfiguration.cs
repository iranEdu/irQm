using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace irQm.BaseCodes.Configurations
{
    class LongAnswerConfiguration : IEntityTypeConfiguration<LongAnswer>
    {
        public void Configure(EntityTypeBuilder<LongAnswer> builder)
        {
            builder.HasOne(q => q.Lesson).WithMany(l => l.LongAnswers).HasForeignKey(l => l.LessonName).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
