using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace irQm.BaseCodes.Configurations
{
    class PracticalQuestionInListConfiguration : IEntityTypeConfiguration<QuestionInList<Practical>>
    {
        public void Configure(EntityTypeBuilder<QuestionInList<Practical>> builder)
        {
            builder.ToTable("PracticalQuestionInList");
            builder.HasOne(q => q.Question).WithMany().OnDelete(DeleteBehavior.Cascade);

        }
    }
}
