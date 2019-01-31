using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace irQm.BaseCodes.Configurations
{
    class TFQuestionConfiguration : IEntityTypeConfiguration<TFQuestion>
    {
        public void Configure(EntityTypeBuilder<TFQuestion> builder)
        {
            
            builder.HasOne(q => q.Lesson).WithMany(l => l.TFQuestions).HasForeignKey(l=>l.LessonName).OnDelete(DeleteBehavior.Cascade);
            
            builder.HasOne(q => q.CreatorUser).WithMany(u => u.TFQuestions).OnDelete(DeleteBehavior.Cascade).HasForeignKey(q => q.CreatorUserId);
        }
    }
}
