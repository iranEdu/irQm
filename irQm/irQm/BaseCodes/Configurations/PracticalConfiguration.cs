using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace irQm.BaseCodes.Configurations
{
    class PracticalConfiguration : IEntityTypeConfiguration<Practical>
    {
        public void Configure(EntityTypeBuilder<Practical> builder)
        {
            builder.HasOne(q => q.Lesson).WithMany(l => l.Practicals).HasForeignKey(l => l.LessonName).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(q => q.CreatorUser).WithMany(u => u.PracticalQuestions).OnDelete(DeleteBehavior.Cascade).HasForeignKey(q => q.CreatorUserId);
            builder.HasMany(q => q.CheckList).WithOne().OnDelete(DeleteBehavior.Cascade);

        }
    }
}
