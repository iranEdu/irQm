using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace irQm.BaseCodes.Configurations
{
    class MultiChoicesQuestionInListConfiguration : IEntityTypeConfiguration<QuestionInList<MultiChoices>>
    {
        public void Configure(EntityTypeBuilder<QuestionInList<MultiChoices>> builder)
        {
            builder.ToTable("MultiChoicesQuestionInList");
            builder.HasOne(q => q.Question).WithMany().OnDelete(DeleteBehavior.Cascade);

        }
    }
}
