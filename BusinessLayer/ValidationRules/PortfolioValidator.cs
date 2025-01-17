﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class PortfolioValidator:AbstractValidator<Porfolio>
    {
      public PortfolioValidator() 
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Proje adı boş geçilemez");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Görsel alanı boş geçilemez");
            RuleFor(x => x.ImageUrl2).NotEmpty().WithMessage("Görsel2 alanı boş geçilemez");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat alanı boş geçilemez");
            RuleFor(x => x.Value).NotEmpty().WithMessage("Değer alanı boş geçilemez");
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Proje Adı En az 5 karakter olmalıdır");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Proje Adı En fazla 30 karakter olmalıdır");
        }
    }
}
