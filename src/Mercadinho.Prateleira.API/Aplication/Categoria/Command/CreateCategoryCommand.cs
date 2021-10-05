using FluentValidation.Results;
using MediatR;
using Mercadinho.Prateleira.API.Aplication.Categoria.Validation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mercadinho.Prateleira.API.Aplication.Categoria.Command
{
    public class CreateCategoryCommand : IRequest<bool>
    {
        public string Descricao { get; set; }

        [JsonIgnore]
        public ValidationResult Validation { get; set; }

        public CreateCategoryCommand(string descricao)
        {
            Descricao = descricao;
            var validator = new CreateCategoryCommandValidator();
            Validation = validator.Validate(this);
        }
    }
}
