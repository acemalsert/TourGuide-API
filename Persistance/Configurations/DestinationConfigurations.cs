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
                .RuleFor(d => d.Id, f => f.IndexFaker + 1) // Id'yi otomatik artırır
                .RuleFor(d => d.Name, f => f.Address.City()) // Şehir isimleri üretir
                .RuleFor(d => d.Description, f => f.Lorem.Paragraph()) // Rastgele açıklamalar
                .RuleFor(d => d.Location, f => f.Address.FullAddress()) // Tam adres üretir
                .RuleFor(d => d.Latitude, f => f.Address.Latitude()) // Rastgele enlem
                .RuleFor(d => d.Longitude, f => f.Address.Longitude()) // Rastgele boylam
                .RuleFor(d => d.OpeningTime, f => TimeSpan.FromHours(f.Random.Int(8, 10))) // Açılış saati (08:00 - 10:00 arası)
                .RuleFor(d => d.ClosingTime, f => TimeSpan.FromHours(f.Random.Int(17, 19))) // Kapanış saati (17:00 - 19:00 arası)
                .RuleFor(d => d.TicketPrice, f => f.Finance.Amount(5, 100)) // Rastgele bilet fiyatı
                .RuleFor(d => d.ImageUrl, f => f.Internet.Avatar()) // Rastgele resim URL'si
                .RuleFor(d => d.CategoryId, f => f.Random.Int(1, 5)); // Rastgele bir kategoriye bağlanır

            builder.HasData(destinationFaker.Generate(10));
        }
    }
}
