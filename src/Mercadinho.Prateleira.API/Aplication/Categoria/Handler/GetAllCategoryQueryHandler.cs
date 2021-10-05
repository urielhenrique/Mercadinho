using MediatR;
using Mercadinho.Prateleira.API.Aplication.Categoria.Query;
using Mercadinho.Prateleira.Infrastructure.Data.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Mercadinho.Prateleira.API.Aplication.Categoria.Handler
{
    public class GetAllCategoryQueryHandler : IRequestHandler<GetAllCategoriesQuery, IEnumerable<Domain.Categoria>>
    {
        private readonly IGenericRepository<Domain.Categoria> _categoriaRepository;

        public GetAllCategoryQueryHandler(IGenericRepository<Domain.Categoria> categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public async Task<IEnumerable<Domain.Categoria>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
        {
            return await _categoriaRepository.GetAllAsync(
                noTracking: true,
                cancellationToken: cancellationToken
                ).ConfigureAwait(false);
        }
    }
}
