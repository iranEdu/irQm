using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace irQm.BaseCodes.Configurations
{
    public class UserConfiguration:IEntityTypeConfiguration<User>
    {
       
        public void Configure(EntityTypeBuilder<User> builder)
        {

            builder.HasIndex(u=>u.UserName).IsUnique();
         
        }
    }
}
