using Bogus;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace TourGuide.Persistance.Configurations
{
    public class DestinationConfiguration : IEntityTypeConfiguration<Destination>
    {
        public void Configure(EntityTypeBuilder<Destination> builder)
        {
            var destinationFaker = new Faker<Destination>()
                .RuleFor(d => d.Id, f => f.IndexFaker + 1)
                .RuleFor(d => d.Name, f => f.Address.City())
                .RuleFor(d => d.Description, f => f.Lorem.Paragraph())
                .RuleFor(d => d.OpeningTime, f => f.Date.Between(DateTime.Today.AddHours(8), DateTime.Today.AddHours(10)))
                .RuleFor(d => d.ClosingTime, f => f.Date.Between(DateTime.Today.AddHours(17), DateTime.Today.AddHours(19)))
                .RuleFor(d => d.TicketPrice, f => f.Finance.Amount(5, 100))
                .RuleFor(d => d.ImageData, f => f.Internet.Avatar())
                .RuleFor(d => d.CategoryId, f => f.Random.Int(1, 5));

            builder.HasData(destinationFaker.Generate(10));
        }
    }
}
