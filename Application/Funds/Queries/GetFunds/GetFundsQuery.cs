using Application.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Funds.Queries.GetFunds
{
  public class GetFundsQuery: IRequest<List<FundsDto>>
  {
  }

  public class GetFundsQueryHandler : IRequestHandler<GetFundsQuery, List<FundsDto>>
  {
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetFundsQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
      _context = context;
      _mapper = mapper;
    }

    public async Task<List<FundsDto>> Handle(GetFundsQuery request, CancellationToken cancellationToken)
    {
      return await _context.Funds
              .AsNoTracking()
              .ProjectTo<FundsDto>(_mapper.ConfigurationProvider)
              .OrderBy(c => c.Name)
              .ToListAsync(cancellationToken);
    }
  }
}
