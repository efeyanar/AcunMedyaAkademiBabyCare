using AcunMedyaAkademiBabyCare.Entities;
using FluentValidation;

namespace AcunMedyaAkademiBabyCare.Validations
{
    public class TeamValidator : AbstractValidator<Team>
    {
        public TeamValidator()
        {
            RuleFor(x => x.NameSurname).NotEmpty().WithMessage("İsim ve soyisim boş geçilemez.");
            RuleFor(x => x.NameSurname).MinimumLength(3).WithMessage("Lütfen isim soyisim bilgilerini kontrol ediniz.");
            RuleFor(x => x.NameSurname).MaximumLength(20).WithMessage("En fazla 20 karakter girebilirsiniz");
            RuleFor(x => x.Age).NotEmpty().WithMessage("Yaş bilgisi boş geçilemez.");
            RuleFor(x => x.City).NotEmpty().WithMessage("Lütfen şehir bilgisi giriniz.");
            RuleFor(x => x.City).MinimumLength(3).WithMessage("Lütfen şehir bilgilerini kontrol ediniz.");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Lütfen resim bilgisi giriniz.");
            RuleFor(x => x.BranchId).NotEmpty().WithMessage("Lütfen branş seçiniz.");


        }
    }
}
