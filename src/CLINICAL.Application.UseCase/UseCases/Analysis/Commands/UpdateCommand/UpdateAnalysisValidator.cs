using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLINICAL.Application.UseCase.UseCases.Analysis.Commands.UpdateCommand
{
    public class UpdateAnalysisValidator : AbstractValidator<UpdateAnalysisCommand>
    {
        public UpdateAnalysisValidator()
        {
            // TODO Revisar MaximumLength

            RuleFor(x => x.Name)
                .NotNull().WithMessage("El campo Nombre no puede ser nulo")
                .NotEmpty().WithMessage("El campo Nombre no puede ser vacío")
                .MaximumLength(50).WithMessage("El nombre no puede superar los 50 caracteres");

            // TODO Regla para el manejo de ID
        }
    }
}
