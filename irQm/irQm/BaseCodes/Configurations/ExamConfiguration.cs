using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace irQm.BaseCodes.Configurations
{
    public class ExamConfiguration:IEntityTypeConfiguration<Exam>
    {
       
        public void Configure(EntityTypeBuilder<Exam> builder)
        {
            
            builder.HasMany(ql => ql.TFQuestions).WithOne().OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(ql => ql.ShortAnswerQuestions).WithOne().OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(ql => ql.LongAnswerQuestions).WithOne().OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(ql => ql.PracticalQuestions).WithOne().OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(ql => ql.MultiChoicesQuestions).WithOne().OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(ql => ql.PuzzleQuestions).WithOne().OnDelete(DeleteBehavior.Cascade);

            builder.HasKey(e => new { e.Id, e.Username });

            builder.HasOne(q=>q.User).WithMany().HasForeignKey(e => e.Username);
        }
    }
}
