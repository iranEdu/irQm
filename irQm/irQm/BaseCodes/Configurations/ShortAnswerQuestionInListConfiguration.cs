using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace irQm.BaseCodes.Configurations
{
    class ShortAnswerQuestionInListConfiguration : IEntityTypeConfiguration<QuestionInList<ShortAnswer>>
    {
        public void Configure(EntityTypeBuilder<QuestionInList<ShortAnswer>> builder)
        {
            builder.ToTable("ShortAnswerQuestionInList");

            builder.HasOne(q => q.Question).WithMany().OnDelete(DeleteBehavior.Cascade);

        }
    }
}
