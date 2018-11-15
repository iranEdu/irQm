using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace irQm.BaseCodes.Configurations
{
    class TagInLongAnswerConfiguration : IEntityTypeConfiguration<TagInQuestion<LongAnswer>>
    {
        public void Configure(EntityTypeBuilder<TagInQuestion<LongAnswer>> builder)
        {
            builder.ToTable("TagInLongAnswer");
            builder.HasKey(tiq => new { tiq.TagId, tiq.QuestionId });
            builder.HasOne(tiq => tiq.Question).WithMany(q => q.Tags).HasForeignKey(tiq => tiq.QuestionId);
            builder.HasOne(tiq => tiq.Tag).WithMany().HasForeignKey(tiq => tiq.TagId);

        }
    }
}
