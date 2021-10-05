using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mercadinho.Prateleira.API.Aplication.Categoria.Query
{
    public class GetAllCategoriesQuery : IRequest<IEnumerable<Domain.Categoria>>
    {
    }
}
