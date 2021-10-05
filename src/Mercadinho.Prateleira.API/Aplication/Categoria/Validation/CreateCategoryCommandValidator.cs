using FluentValidation;
using Mercadinho.Prateleira.API.Aplication.Categoria.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mercadinho.Prateleira.API.Aplication.Categoria.Validation
{
    public class CreateCategoryCommandValidator : AbstractValidator<CreateCategoryCommand>
    {
        public CreateCategoryCommandValidator()
        {
            RuleFor(x => x.Descricao)
                .NotNull()
                .NotEmpty()
                .MaximumLength(50);
        }
    }
}
