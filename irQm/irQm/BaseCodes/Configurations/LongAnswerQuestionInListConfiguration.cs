using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace irQm.BaseCodes.Configurations
{
    class LongAnswerQuestionInListConfiguration : IEntityTypeConfiguration<QuestionInList<LongAnswer>>
    {
        public void Configure(EntityTypeBuilder<QuestionInList<LongAnswer>> builder)
        {
            builder.ToTable("LongAnswerQuestionInList");

            builder.HasOne(q => q.Question).WithMany().OnDelete(DeleteBehavior.Cascade);

        }
    }
}
