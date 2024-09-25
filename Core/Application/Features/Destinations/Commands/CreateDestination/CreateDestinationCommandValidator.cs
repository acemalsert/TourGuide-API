using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourGuide.Application.Features.Destinations.Commands.CreateDestination
{
    public class CreateDestinationCommandValidator : AbstractValidator<CreateDestinationCommandRequest>
    {
        public CreateDestinationCommandValidator()
        {

            // burası güncellenecek
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithName("İsim");

            //RuleFor(x => x.Description)
            //    .NotEmpty()
            //    .WithName("Açıklama");

            //RuleFor(x => x.BrandId)
            //    .GreaterThan(0)
            //    .WithName("Marka");

            //RuleFor(x => x.Price)
            //    .GreaterThan(0)
            //    .WithName("Fiyat");

            //RuleFor(x => x.Discount)
            //    .GreaterThanOrEqualTo(0)
            //    .WithName("İndirim Oranı");

            //RuleFor(x => x.CategoryIds)
            //    .NotEmpty()
            //    .Must(categories => categories.Any())
            //    .WithName("Kategoriler");
        }
        }
    }
