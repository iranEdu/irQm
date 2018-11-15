﻿using Microsoft.EntityFrameworkCore;
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
            builder.HasMany(q => q.Options).WithOne().OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(q => q.Lesson).WithMany(l => l.MultiChoicesQusestions).HasForeignKey(l => l.LessonName).OnDelete(DeleteBehavior.Cascade);
            builder.Property(m => m.MultiSelections).HasField("multiSelection");

        }
    }
}
