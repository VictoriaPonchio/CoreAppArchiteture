using AutoMapper;
using AutoMapper.QueryableExtensions;
using CoreAppArchiteture.Core.Interfaces;
using CoreAppArchiteture.Infrastructure;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CoreAppArchiteture.Application.ShoppingLists.Queries
{
    public class GetAllShoppingListsHandler : IRequestHandler<GetAllShoppingListsQuery, ShoppingListVm>
    {
        private readonly CoreAppContext _context;
        //private readonly IRepositoryAsync _repository;
        private readonly IMapper _mapper;

        public GetAllShoppingListsHandler(CoreAppContext context , IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        
        public async Task<ShoppingListVm> Handle(GetAllShoppingListsQuery request, CancellationToken cancellationToken)
        {
            //var list = await _repository.ListAllAsync();

            var list = await _context.ShoppingLists
                 .ProjectTo<ShoppingListLookupDto>(_mapper.ConfigurationProvider)
                 .ToListAsync(cancellationToken);

            var vm = new ShoppingListVm
            {
                ShopingLists = list
            };

            return vm;
        }
    }
}
