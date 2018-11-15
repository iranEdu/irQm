using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace irQm.BaseCodes.Configurations
{
    class TagInShortAnswerConfiguration : IEntityTypeConfiguration<TagInQuestion<ShortAnswer>>
    {
        public void Configure(EntityTypeBuilder<TagInQuestion<ShortAnswer>> builder)
        {
            builder.ToTable("TagInShortAnswer");
            builder.HasKey(tiq => new { tiq.TagId, tiq.QuestionId });
            builder.HasOne(tiq => tiq.Question).WithMany(q => q.Tags).HasForeignKey(tiq => tiq.QuestionId);
            builder.HasOne(tiq => tiq.Tag).WithMany().HasForeignKey(tiq => tiq.TagId);

        }
    }
}
