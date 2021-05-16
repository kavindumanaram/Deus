using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deus.Domain.Users;

namespace Deus.Persistence.Configuration
{
    public class UserConfiguration : EntityTypeConfiguration<Domain.Users.User>
    {
        public UserConfiguration()
        {
            HasKey(t => t.UserId);
            Property(t => t.UserId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.FirstName).IsRequired();
            Property(t => t.LastName).IsRequired();
            ToTable("User");
        }
    }
}