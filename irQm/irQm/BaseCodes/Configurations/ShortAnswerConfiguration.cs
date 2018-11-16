using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace irQm.BaseCodes.Configurations
{
    class ShortAnswerConfiguration : IEntityTypeConfiguration<ShortAnswer>
    {
        public void Configure(EntityTypeBuilder<ShortAnswer> builder)
        {
            builder.HasOne(q => q.Lesson).WithMany(l => l.ShortAnswers).HasForeignKey(l => l.LessonName).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(q => q.CreatedBy).WithMany().OnDelete(DeleteBehavior.Cascade);

        }
    }
}
