using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irQm.BaseCodes.Configurations
{
    public class MultiChoicesConfiguration : IEntityTypeConfiguration<MultiChoices>
    {
        public void Configure(EntityTypeBuilder<MultiChoices> builder)
        {
            builder.HasMany(q => q.Options).WithOne().OnDelete(DeleteBehavior.Cascade).HasForeignKey(o=>o.MultiChoicesId);
            builder.HasOne(q => q.Lesson).WithMany(l => l.Multichoices).HasForeignKey(l => l.LessonName).OnDelete(DeleteBehavior.Cascade);
            builder.Property(m => m.MultiSelections).HasField("multiSelection");
            builder.HasOne(q => q.CreatorUser).WithMany(u=>u.MultiChoicesQuestions).OnDelete(DeleteBehavior.Cascade).HasForeignKey(q => q.CreatorUserId);
         

        }
    }
}
