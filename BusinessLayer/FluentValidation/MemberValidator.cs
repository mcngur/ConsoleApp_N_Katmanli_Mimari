using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class MemberValidator : AbstractValidator<Member>
    {
        public MemberValidator()
        {
            RuleFor(x => x.MemberName).NotEmpty().WithMessage("Üye Adı Boş Geçilemez");
            RuleFor(x => x.MemberSurName).NotEmpty().WithMessage("Üye Soyadı Boş Geçilemez");
            RuleFor(x => x.MemberName).MinimumLength(3).WithMessage("Üye Adı En az 3 Karekter olmalı ");
            RuleFor(x => x.MemberSurName).MinimumLength(2).WithMessage("Üye Soyadı En az 2 karekter olmalı");
            RuleFor(x => x.MemberSurName).MaximumLength(30).WithMessage("Üye Adı En fazla 30 karekter olmalı");
            
        }
    }
}
