using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace irQm.BaseCodes.Configurations
{
    class TagInTfQuestionConfiguration : IEntityTypeConfiguration<TagInQuestion<TFQuestion>>
    {
        public void Configure(EntityTypeBuilder<TagInQuestion<TFQuestion>> builder)
        {
            builder.ToTable("TagInTfQuestion");
            builder.HasKey(tiq => new { tiq.TagId, tiq.QuestionId });
            builder.HasOne(tiq => tiq.Question).WithMany(q => q.Tags).HasForeignKey(tiq => tiq.QuestionId);
            builder.HasOne(tiq => tiq.Tag).WithMany().HasForeignKey(tiq => tiq.TagId);

        }
    }
}
