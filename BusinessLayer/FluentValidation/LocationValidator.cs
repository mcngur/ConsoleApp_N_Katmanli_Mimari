using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    internal class LocationValidator : AbstractValidator<Location>
    {
        public LocationValidator()
        {
            RuleFor(x => x.LocationName).NotEmpty().WithMessage("Lokasyon Adı Boş Geçilemez");
            RuleFor(x => x.LocationName).MinimumLength(3).WithMessage("Lokasyon Adı En az 3 Karekter olmalı ");
        }
    }
}
