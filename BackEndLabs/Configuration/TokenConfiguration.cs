using BackEndLabs.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BackEndLabs.Configuration
{
    internal class TokenConfiguration : IEntityTypeConfiguration<Token>
    {
        public void Configure(EntityTypeBuilder<Token> builder)
        {
            builder.HasQueryFilter(t => t.ExpiresAt > DateTime.UtcNow);
        }
    }
}