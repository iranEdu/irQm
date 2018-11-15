using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace irQm.BaseCodes.Configurations
{
    class TFQuestionInListConfiguration : IEntityTypeConfiguration<QuestionInList<TFQuestion>>
    {
        public void Configure(EntityTypeBuilder<QuestionInList<TFQuestion>> builder)
        {
            builder.ToTable("TFQuestionInList");
            builder.HasOne(q => q.Question).WithMany().OnDelete(DeleteBehavior.Cascade);

        }
    }
}
