using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace irQm.BaseCodes.Configurations
{
    class PuzzleQuestionInListConfiguration : IEntityTypeConfiguration<QuestionInList<Puzzle>>
    {
        public void Configure(EntityTypeBuilder<QuestionInList<Puzzle>> builder)
        {
            builder.ToTable("PuzzleQuestionInList");
            builder.HasOne(q => q.Question).WithMany().OnDelete(DeleteBehavior.Cascade);

        }
    }
}
