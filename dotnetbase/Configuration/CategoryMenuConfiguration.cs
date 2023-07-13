using dotnetbase.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace dotnetbase.Configuration;

public class CategoryMenuConfiguration: IEntityTypeConfiguration<CategoryMenu>
{
    public void Configure(EntityTypeBuilder<CategoryMenu> builder)
    {

        builder.ToTable("Categories");
        builder.HasKey(x => x.Id);

    }
}