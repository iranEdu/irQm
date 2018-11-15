using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace irQm.BaseCodes.Configurations
{
    class TagInPuzzleConfiguration : IEntityTypeConfiguration<TagInQuestion<Puzzle>>
    {
        public void Configure(EntityTypeBuilder<TagInQuestion<Puzzle>> builder)
        {
            builder.ToTable("TagInPuzzle");
            builder.HasKey(tiq => new { tiq.TagId, tiq.QuestionId });
            builder.HasOne(tiq => tiq.Question).WithMany(q => q.Tags).HasForeignKey(tiq => tiq.QuestionId);
            builder.HasOne(tiq => tiq.Tag).WithMany().HasForeignKey(tiq => tiq.TagId);

        }
    }
}
