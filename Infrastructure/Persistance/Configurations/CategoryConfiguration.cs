using Bogus;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourGuide.Persistance.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            var categoryFaker = new Faker<Category>()
                .RuleFor(c => c.Id, f => f.IndexFaker + 1) 
                .RuleFor(c => c.CategoryName, f => f.Commerce.Categories(1)[0]) 
                .RuleFor(c => c.CreatedDate, f => f.Date.Past(2))
                .RuleFor(c => c.IsDeleted, f => false); 

            builder.HasData(categoryFaker.Generate(5));
        }
    }
}
